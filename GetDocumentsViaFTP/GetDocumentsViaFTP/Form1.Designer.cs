namespace GetDocumentsViaFTP
{
    partial class ftp_tester
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ip_textBox = new System.Windows.Forms.TextBox();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.pw_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connect_button = new System.Windows.Forms.Button();
            this.logs_listBox = new System.Windows.Forms.ListBox();
            this.download_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ip_textBox
            // 
            this.ip_textBox.Location = new System.Drawing.Point(47, 12);
            this.ip_textBox.Name = "ip_textBox";
            this.ip_textBox.Size = new System.Drawing.Size(290, 20);
            this.ip_textBox.TabIndex = 0;
            this.ip_textBox.Text = "192.168.0.55";
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(47, 38);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(290, 20);
            this.id_textBox.TabIndex = 0;
            this.id_textBox.Text = "dgm";
            // 
            // pw_textBox
            // 
            this.pw_textBox.Location = new System.Drawing.Point(47, 64);
            this.pw_textBox.Name = "pw_textBox";
            this.pw_textBox.Size = new System.Drawing.Size(290, 20);
            this.pw_textBox.TabIndex = 0;
            this.pw_textBox.Text = "dgm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "PW:";
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(362, 12);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(79, 72);
            this.connect_button.TabIndex = 2;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // logs_listBox
            // 
            this.logs_listBox.BackColor = System.Drawing.SystemColors.Info;
            this.logs_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs_listBox.FormattingEnabled = true;
            this.logs_listBox.HorizontalScrollbar = true;
            this.logs_listBox.Location = new System.Drawing.Point(18, 100);
            this.logs_listBox.Name = "logs_listBox";
            this.logs_listBox.Size = new System.Drawing.Size(422, 524);
            this.logs_listBox.TabIndex = 3;
            // 
            // download_timer
            // 
            this.download_timer.Interval = 5000;
            this.download_timer.Tick += new System.EventHandler(this.download_timer_Tick);
            // 
            // ftp_tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 633);
            this.Controls.Add(this.logs_listBox);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pw_textBox);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.ip_textBox);
            this.Name = "ftp_tester";
            this.Text = "FTP Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ftp_tester_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip_textBox;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox pw_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.ListBox logs_listBox;
        private System.Windows.Forms.Timer download_timer;
    }
}

