using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentFTP;
using System.Net;

namespace GetDocumentsViaFTP
{
    public partial class ftp_tester : Form
    {
        FtpClient client = null;

        public ftp_tester()
        {
            InitializeComponent();

            // create an FTP client
            this.client = new FtpClient();
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
             this.client.Host = this.ip_textBox.Text;

            // if you don't specify login credentials, we use the "anonymous" user account
            this.client.Credentials = new NetworkCredential(this.id_textBox.Text, this.pw_textBox.Text);

            // begin connecting to the server     
            this.client.Connect();
            if (true == this.client.IsConnected)
            {
                // Change Encoding
                this.client.Encoding = Encoding.UTF8;
                this.MessageHandler_Message(string.Format("Connet to IP: {0}", this.ip_textBox.Text));

                this.download_timer.Interval = 2000;
                this.download_timer.Start();         
            }
        }

        private void MessageHandler_Message(string sMessage)
        {
            var writeMessageAction = new Action(
                () =>
                {
                    this.logs_listBox.BeginUpdate();

                    int nItem = this.logs_listBox.Items.Add(string.Format("[{0}] {1}", System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), sMessage));

                    if (this.logs_listBox.Items.Count > 5000)
                    {
                        this.logs_listBox.Items.RemoveAt(0);
                    }

                    if (this.logs_listBox.SelectedIndex < 0)
                    {
                        this.logs_listBox.TopIndex = nItem;
                    }
                    else if (this.logs_listBox.SelectedIndex == nItem - 1)
                    {
                        this.logs_listBox.SelectedIndex = nItem;
                    }

                    this.logs_listBox.EndUpdate();
                });

            if (this.logs_listBox.InvokeRequired)
                this.logs_listBox.Invoke(writeMessageAction);
            else
                writeMessageAction();
        }

        private void download_timer_Tick(object sender, EventArgs e)
        {
            try
            {
                foreach (FtpListItem item in this.client.GetListing(this.client.GetWorkingDirectory()))
                {
                    switch (item.Type)
                    {
                        case FtpFileSystemObjectType.Directory:
                            break;
                        case FtpFileSystemObjectType.File:
                            this.MessageHandler_Message(string.Format("File Name: {0}", item.FullName));
                            this.client.DownloadFile(string.Format(@"D:\TCPIP_test\dgme\{0}", item.Name), item.FullName);
                            this.client.DeleteFile(item.FullName);
                            this.MessageHandler_Message(string.Format("Finished: {0} (size:{1})", item.FullName, item.Size));
                            break;
                        case FtpFileSystemObjectType.Link:
                            break;
                    }
                }
            }
            catch (Exception)
            {
            }
   
        }

        private void ftp_tester_FormClosing(object sender, FormClosingEventArgs e)
        {            
            this.download_timer.Stop();
            this.client.Disconnect();
        }
    }
}
