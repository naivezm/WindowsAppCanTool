namespace WindowsCanToolApp
{
    partial class ComSetting
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.COMpanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.COMSettingsgroupBox = new System.Windows.Forms.GroupBox();
            this.StopBitscomboBox = new System.Windows.Forms.ComboBox();
            this.DataBitscomboBox = new System.Windows.Forms.ComboBox();
            this.ParityErrorCharcomboBox = new System.Windows.Forms.ComboBox();
            this.ParitycomboBox = new System.Windows.Forms.ComboBox();
            this.BaudRatecomboBox = new System.Windows.Forms.ComboBox();
            this.StopBitslabel = new System.Windows.Forms.Label();
            this.DataBitslabel = new System.Windows.Forms.Label();
            this.ParityErrorCharlabel = new System.Windows.Forms.Label();
            this.Paritylabel = new System.Windows.Forms.Label();
            this.BaudRatelabel = new System.Windows.Forms.Label();
            this.COMSelectgroupBox = new System.Windows.Forms.GroupBox();
            this.Explainlabel2 = new System.Windows.Forms.Label();
            this.Explainlabel1 = new System.Windows.Forms.Label();
            this.COMcomboBox = new System.Windows.Forms.ComboBox();
            this.SendAndRecvlabel = new System.Windows.Forms.Label();
            this.COMpanel.SuspendLayout();
            this.COMSettingsgroupBox.SuspendLayout();
            this.COMSelectgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // COMpanel
            // 
            this.COMpanel.Controls.Add(this.button3);
            this.COMpanel.Controls.Add(this.button2);
            this.COMpanel.Controls.Add(this.button1);
            this.COMpanel.Controls.Add(this.COMSettingsgroupBox);
            this.COMpanel.Controls.Add(this.COMSelectgroupBox);
            this.COMpanel.Location = new System.Drawing.Point(0, -5);
            this.COMpanel.Name = "COMpanel";
            this.COMpanel.Size = new System.Drawing.Size(545, 355);
            this.COMpanel.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(464, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Help";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // COMSettingsgroupBox
            // 
            this.COMSettingsgroupBox.Controls.Add(this.StopBitscomboBox);
            this.COMSettingsgroupBox.Controls.Add(this.DataBitscomboBox);
            this.COMSettingsgroupBox.Controls.Add(this.ParityErrorCharcomboBox);
            this.COMSettingsgroupBox.Controls.Add(this.ParitycomboBox);
            this.COMSettingsgroupBox.Controls.Add(this.BaudRatecomboBox);
            this.COMSettingsgroupBox.Controls.Add(this.StopBitslabel);
            this.COMSettingsgroupBox.Controls.Add(this.DataBitslabel);
            this.COMSettingsgroupBox.Controls.Add(this.ParityErrorCharlabel);
            this.COMSettingsgroupBox.Controls.Add(this.Paritylabel);
            this.COMSettingsgroupBox.Controls.Add(this.BaudRatelabel);
            this.COMSettingsgroupBox.Location = new System.Drawing.Point(3, 114);
            this.COMSettingsgroupBox.Name = "COMSettingsgroupBox";
            this.COMSettingsgroupBox.Size = new System.Drawing.Size(536, 181);
            this.COMSettingsgroupBox.TabIndex = 1;
            this.COMSettingsgroupBox.TabStop = false;
            this.COMSettingsgroupBox.Text = "COM port Settings.";
            // 
            // StopBitscomboBox
            // 
            this.StopBitscomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StopBitscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBitscomboBox.FormattingEnabled = true;
            this.StopBitscomboBox.Items.AddRange(new object[] {
            "1"});
            this.StopBitscomboBox.Location = new System.Drawing.Point(392, 72);
            this.StopBitscomboBox.Name = "StopBitscomboBox";
            this.StopBitscomboBox.Size = new System.Drawing.Size(121, 20);
            this.StopBitscomboBox.TabIndex = 9;
            // 
            // DataBitscomboBox
            // 
            this.DataBitscomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataBitscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBitscomboBox.FormattingEnabled = true;
            this.DataBitscomboBox.Items.AddRange(new object[] {
            "8"});
            this.DataBitscomboBox.Location = new System.Drawing.Point(392, 34);
            this.DataBitscomboBox.Name = "DataBitscomboBox";
            this.DataBitscomboBox.Size = new System.Drawing.Size(121, 20);
            this.DataBitscomboBox.TabIndex = 8;
            // 
            // ParityErrorCharcomboBox
            // 
            this.ParityErrorCharcomboBox.FormattingEnabled = true;
            this.ParityErrorCharcomboBox.Location = new System.Drawing.Point(148, 107);
            this.ParityErrorCharcomboBox.Name = "ParityErrorCharcomboBox";
            this.ParityErrorCharcomboBox.Size = new System.Drawing.Size(121, 20);
            this.ParityErrorCharcomboBox.TabIndex = 7;
            // 
            // ParitycomboBox
            // 
            this.ParitycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParitycomboBox.FormattingEnabled = true;
            this.ParitycomboBox.Items.AddRange(new object[] {
            "ODD",
            "EVEN",
            "MARK",
            "SPACE",
            "NONE"});
            this.ParitycomboBox.Location = new System.Drawing.Point(148, 72);
            this.ParitycomboBox.Name = "ParitycomboBox";
            this.ParitycomboBox.Size = new System.Drawing.Size(121, 20);
            this.ParitycomboBox.TabIndex = 6;
            // 
            // BaudRatecomboBox
            // 
            this.BaudRatecomboBox.FormattingEnabled = true;
            this.BaudRatecomboBox.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.BaudRatecomboBox.Location = new System.Drawing.Point(148, 34);
            this.BaudRatecomboBox.Name = "BaudRatecomboBox";
            this.BaudRatecomboBox.Size = new System.Drawing.Size(121, 20);
            this.BaudRatecomboBox.TabIndex = 5;
            // 
            // StopBitslabel
            // 
            this.StopBitslabel.AutoSize = true;
            this.StopBitslabel.Location = new System.Drawing.Point(314, 75);
            this.StopBitslabel.Name = "StopBitslabel";
            this.StopBitslabel.Size = new System.Drawing.Size(59, 12);
            this.StopBitslabel.TabIndex = 4;
            this.StopBitslabel.Text = "Stop Bits";
            // 
            // DataBitslabel
            // 
            this.DataBitslabel.AutoSize = true;
            this.DataBitslabel.Location = new System.Drawing.Point(314, 39);
            this.DataBitslabel.Name = "DataBitslabel";
            this.DataBitslabel.Size = new System.Drawing.Size(59, 12);
            this.DataBitslabel.TabIndex = 3;
            this.DataBitslabel.Text = "Data Bits";
            // 
            // ParityErrorCharlabel
            // 
            this.ParityErrorCharlabel.AutoSize = true;
            this.ParityErrorCharlabel.Location = new System.Drawing.Point(22, 115);
            this.ParityErrorCharlabel.Name = "ParityErrorCharlabel";
            this.ParityErrorCharlabel.Size = new System.Drawing.Size(113, 12);
            this.ParityErrorCharlabel.TabIndex = 2;
            this.ParityErrorCharlabel.Text = "Parity Error Char.";
            // 
            // Paritylabel
            // 
            this.Paritylabel.AutoSize = true;
            this.Paritylabel.Location = new System.Drawing.Point(22, 75);
            this.Paritylabel.Name = "Paritylabel";
            this.Paritylabel.Size = new System.Drawing.Size(41, 12);
            this.Paritylabel.TabIndex = 1;
            this.Paritylabel.Text = "Parity";
            // 
            // BaudRatelabel
            // 
            this.BaudRatelabel.AutoSize = true;
            this.BaudRatelabel.Location = new System.Drawing.Point(22, 39);
            this.BaudRatelabel.Name = "BaudRatelabel";
            this.BaudRatelabel.Size = new System.Drawing.Size(59, 12);
            this.BaudRatelabel.TabIndex = 0;
            this.BaudRatelabel.Text = "Baud Rate";
            // 
            // COMSelectgroupBox
            // 
            this.COMSelectgroupBox.Controls.Add(this.Explainlabel2);
            this.COMSelectgroupBox.Controls.Add(this.Explainlabel1);
            this.COMSelectgroupBox.Controls.Add(this.COMcomboBox);
            this.COMSelectgroupBox.Controls.Add(this.SendAndRecvlabel);
            this.COMSelectgroupBox.Location = new System.Drawing.Point(3, 3);
            this.COMSelectgroupBox.Name = "COMSelectgroupBox";
            this.COMSelectgroupBox.Size = new System.Drawing.Size(536, 105);
            this.COMSelectgroupBox.TabIndex = 0;
            this.COMSelectgroupBox.TabStop = false;
            // 
            // Explainlabel2
            // 
            this.Explainlabel2.AutoSize = true;
            this.Explainlabel2.Location = new System.Drawing.Point(14, 85);
            this.Explainlabel2.Name = "Explainlabel2";
            this.Explainlabel2.Size = new System.Drawing.Size(281, 12);
            this.Explainlabel2.TabIndex = 3;
            this.Explainlabel2.Text = "connection.See the Online Help(F1) for details";
            // 
            // Explainlabel1
            // 
            this.Explainlabel1.AutoSize = true;
            this.Explainlabel1.Location = new System.Drawing.Point(14, 66);
            this.Explainlabel1.Name = "Explainlabel1";
            this.Explainlabel1.Size = new System.Drawing.Size(299, 12);
            this.Explainlabel1.TabIndex = 2;
            this.Explainlabel1.Text = "Choose a COM port (e.g.COM3) or specify a network";
            // 
            // COMcomboBox
            // 
            this.COMcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMcomboBox.FormattingEnabled = true;
            this.COMcomboBox.Location = new System.Drawing.Point(16, 32);
            this.COMcomboBox.Name = "COMcomboBox";
            this.COMcomboBox.Size = new System.Drawing.Size(162, 20);
            this.COMcomboBox.TabIndex = 1;
            // 
            // SendAndRecvlabel
            // 
            this.SendAndRecvlabel.AutoSize = true;
            this.SendAndRecvlabel.Location = new System.Drawing.Point(14, 17);
            this.SendAndRecvlabel.Name = "SendAndRecvlabel";
            this.SendAndRecvlabel.Size = new System.Drawing.Size(137, 12);
            this.SendAndRecvlabel.TabIndex = 0;
            this.SendAndRecvlabel.Text = "Send/Recvieve on Comm.";
            // 
            // ComSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.COMpanel);
            this.Name = "ComSetting";
            this.Size = new System.Drawing.Size(648, 353);
            this.COMpanel.ResumeLayout(false);
            this.COMSettingsgroupBox.ResumeLayout(false);
            this.COMSettingsgroupBox.PerformLayout();
            this.COMSelectgroupBox.ResumeLayout(false);
            this.COMSelectgroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel COMpanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox COMSettingsgroupBox;
        private System.Windows.Forms.ComboBox StopBitscomboBox;
        private System.Windows.Forms.ComboBox DataBitscomboBox;
        private System.Windows.Forms.ComboBox ParityErrorCharcomboBox;
        private System.Windows.Forms.ComboBox ParitycomboBox;
        private System.Windows.Forms.ComboBox BaudRatecomboBox;
        private System.Windows.Forms.Label StopBitslabel;
        private System.Windows.Forms.Label DataBitslabel;
        private System.Windows.Forms.Label ParityErrorCharlabel;
        private System.Windows.Forms.Label Paritylabel;
        private System.Windows.Forms.Label BaudRatelabel;
        private System.Windows.Forms.GroupBox COMSelectgroupBox;
        private System.Windows.Forms.Label Explainlabel2;
        private System.Windows.Forms.Label Explainlabel1;
        private System.Windows.Forms.ComboBox COMcomboBox;
        private System.Windows.Forms.Label SendAndRecvlabel;
    }
}
