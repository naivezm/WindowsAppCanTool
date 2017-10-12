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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StopBitscomboBox = new System.Windows.Forms.ComboBox();
            this.DataBitscomboBox = new System.Windows.Forms.ComboBox();
            this.ParityErrorCharcomboBox = new System.Windows.Forms.ComboBox();
            this.ParitycomboBox = new System.Windows.Forms.ComboBox();
            this.BaudRatecomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Explainlabel2 = new System.Windows.Forms.Label();
            this.Explainlabel1 = new System.Windows.Forms.Label();
            this.COMcomboBox = new System.Windows.Forms.ComboBox();
            this.SendAndRecvlabel = new System.Windows.Forms.Label();
            this.COMpanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // COMpanel
            // 
            this.COMpanel.Controls.Add(this.button3);
            this.COMpanel.Controls.Add(this.button2);
            this.COMpanel.Controls.Add(this.button1);
            this.COMpanel.Controls.Add(this.groupBox2);
            this.COMpanel.Controls.Add(this.groupBox1);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StopBitscomboBox);
            this.groupBox2.Controls.Add(this.DataBitscomboBox);
            this.groupBox2.Controls.Add(this.ParityErrorCharcomboBox);
            this.groupBox2.Controls.Add(this.ParitycomboBox);
            this.groupBox2.Controls.Add(this.BaudRatecomboBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(3, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COM port Settings.";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "Stop Bits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Data Bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Parity Error Char.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Baud Rate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Explainlabel2);
            this.groupBox1.Controls.Add(this.Explainlabel1);
            this.groupBox1.Controls.Add(this.COMcomboBox);
            this.groupBox1.Controls.Add(this.SendAndRecvlabel);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel COMpanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox StopBitscomboBox;
        private System.Windows.Forms.ComboBox DataBitscomboBox;
        private System.Windows.Forms.ComboBox ParityErrorCharcomboBox;
        private System.Windows.Forms.ComboBox ParitycomboBox;
        private System.Windows.Forms.ComboBox BaudRatecomboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Explainlabel2;
        private System.Windows.Forms.Label Explainlabel1;
        private System.Windows.Forms.ComboBox COMcomboBox;
        private System.Windows.Forms.Label SendAndRecvlabel;
    }
}
