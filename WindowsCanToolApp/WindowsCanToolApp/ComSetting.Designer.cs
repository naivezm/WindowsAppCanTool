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
            this.COMPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.COMSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.StopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.DataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.ParityErrorCharComboBox = new System.Windows.Forms.ComboBox();
            this.ParityComboBox = new System.Windows.Forms.ComboBox();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.StopBitsLabel = new System.Windows.Forms.Label();
            this.DataBitsLabel = new System.Windows.Forms.Label();
            this.ParityErrorCharLabel = new System.Windows.Forms.Label();
            this.ParityLabel = new System.Windows.Forms.Label();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.COMSelectGroupBox = new System.Windows.Forms.GroupBox();
            this.ExplainLabelSecondLine = new System.Windows.Forms.Label();
            this.ExplainLabelFirstLine = new System.Windows.Forms.Label();
            this.COMComboBox = new System.Windows.Forms.ComboBox();
            this.SendAndRecvLabel = new System.Windows.Forms.Label();
            this.COMPanel.SuspendLayout();
            this.COMSettingsGroupBox.SuspendLayout();
            this.COMSelectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // COMPanel
            // 
            this.COMPanel.Controls.Add(this.CloseButton);
            this.COMPanel.Controls.Add(this.OpenButton);
            this.COMPanel.Controls.Add(this.COMSettingsGroupBox);
            this.COMPanel.Controls.Add(this.COMSelectGroupBox);
            this.COMPanel.Location = new System.Drawing.Point(0, -5);
            this.COMPanel.Name = "COMPanel";
            this.COMPanel.Size = new System.Drawing.Size(545, 355);
            this.COMPanel.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(441, 301);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Enabled = false;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(241, 301);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 2;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // COMSettingsGroupBox
            // 
            this.COMSettingsGroupBox.Controls.Add(this.StopBitsComboBox);
            this.COMSettingsGroupBox.Controls.Add(this.DataBitsComboBox);
            this.COMSettingsGroupBox.Controls.Add(this.ParityErrorCharComboBox);
            this.COMSettingsGroupBox.Controls.Add(this.ParityComboBox);
            this.COMSettingsGroupBox.Controls.Add(this.BaudRateComboBox);
            this.COMSettingsGroupBox.Controls.Add(this.StopBitsLabel);
            this.COMSettingsGroupBox.Controls.Add(this.DataBitsLabel);
            this.COMSettingsGroupBox.Controls.Add(this.ParityErrorCharLabel);
            this.COMSettingsGroupBox.Controls.Add(this.ParityLabel);
            this.COMSettingsGroupBox.Controls.Add(this.BaudRateLabel);
            this.COMSettingsGroupBox.Location = new System.Drawing.Point(3, 114);
            this.COMSettingsGroupBox.Name = "COMSettingsGroupBox";
            this.COMSettingsGroupBox.Size = new System.Drawing.Size(536, 181);
            this.COMSettingsGroupBox.TabIndex = 1;
            this.COMSettingsGroupBox.TabStop = false;
            this.COMSettingsGroupBox.Text = "COM port Settings.";
            // 
            // StopBitsComboBox
            // 
            this.StopBitsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StopBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBitsComboBox.FormattingEnabled = true;
            //this.StopBitsComboBox.Items.AddRange(new object[] {
            //"1"});
            this.StopBitsComboBox.Location = new System.Drawing.Point(392, 72);
            this.StopBitsComboBox.Name = "StopBitsComboBox";
            this.StopBitsComboBox.Size = new System.Drawing.Size(121, 20);
            this.StopBitsComboBox.TabIndex = 9;
            // 
            // DataBitsComboBox
            // 
            this.DataBitsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBitsComboBox.FormattingEnabled = true;
            //this.DataBitsComboBox.Items.AddRange(new object[] {
            //"8"});
            this.DataBitsComboBox.Location = new System.Drawing.Point(392, 34);
            this.DataBitsComboBox.Name = "DataBitsComboBox";
            this.DataBitsComboBox.Size = new System.Drawing.Size(121, 20);
            this.DataBitsComboBox.TabIndex = 8;
            // 
            // ParityErrorCharComboBox
            // 
            this.ParityErrorCharComboBox.FormattingEnabled = true;
            this.ParityErrorCharComboBox.Location = new System.Drawing.Point(148, 107);
            this.ParityErrorCharComboBox.Name = "ParityErrorCharComboBox";
            this.ParityErrorCharComboBox.Size = new System.Drawing.Size(121, 20);
            this.ParityErrorCharComboBox.TabIndex = 7;
            // 
            // ParityComboBox
            // 
            this.ParityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParityComboBox.FormattingEnabled = true;
            //this.ParityComboBox.Items.AddRange(new object[] {
            //"ODD",
            //"EVEN",
            //"MARK",
            //"SPACE",
            //"NONE"});
            this.ParityComboBox.Location = new System.Drawing.Point(148, 72);
            this.ParityComboBox.Name = "ParityComboBox";
            this.ParityComboBox.Size = new System.Drawing.Size(121, 20);
            this.ParityComboBox.TabIndex = 6;
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.FormattingEnabled = true;
            //this.BaudRateComboBox.Items.AddRange(new object[] {
            //"1200",
            //"2400",
            //"4800",
            //"9600",
            //"19200",
            //"38400",
            //"43000",
            //"56000",
            //"57600",
            //"115200"});
            this.BaudRateComboBox.Location = new System.Drawing.Point(148, 34);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(121, 20);
            this.BaudRateComboBox.TabIndex = 5;
            // 
            // StopBitsLabel
            // 
            this.StopBitsLabel.AutoSize = true;
            this.StopBitsLabel.Location = new System.Drawing.Point(314, 75);
            this.StopBitsLabel.Name = "StopBitsLabel";
            this.StopBitsLabel.Size = new System.Drawing.Size(59, 12);
            this.StopBitsLabel.TabIndex = 4;
            this.StopBitsLabel.Text = "Stop Bits";
            // 
            // DataBitsLabel
            // 
            this.DataBitsLabel.AutoSize = true;
            this.DataBitsLabel.Location = new System.Drawing.Point(314, 39);
            this.DataBitsLabel.Name = "DataBitsLabel";
            this.DataBitsLabel.Size = new System.Drawing.Size(59, 12);
            this.DataBitsLabel.TabIndex = 3;
            this.DataBitsLabel.Text = "Data Bits";
            // 
            // ParityErrorCharLabel
            // 
            this.ParityErrorCharLabel.AutoSize = true;
            this.ParityErrorCharLabel.Location = new System.Drawing.Point(22, 115);
            this.ParityErrorCharLabel.Name = "ParityErrorCharLabel";
            this.ParityErrorCharLabel.Size = new System.Drawing.Size(113, 12);
            this.ParityErrorCharLabel.TabIndex = 2;
            this.ParityErrorCharLabel.Text = "Parity Error Char.";
            // 
            // ParityLabel
            // 
            this.ParityLabel.AutoSize = true;
            this.ParityLabel.Location = new System.Drawing.Point(22, 75);
            this.ParityLabel.Name = "ParityLabel";
            this.ParityLabel.Size = new System.Drawing.Size(41, 12);
            this.ParityLabel.TabIndex = 1;
            this.ParityLabel.Text = "Parity";
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Location = new System.Drawing.Point(22, 39);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(59, 12);
            this.BaudRateLabel.TabIndex = 0;
            this.BaudRateLabel.Text = "Baud Rate";
            // 
            // COMSelectGroupBox
            // 
            this.COMSelectGroupBox.Controls.Add(this.ExplainLabelSecondLine);
            this.COMSelectGroupBox.Controls.Add(this.ExplainLabelFirstLine);
            this.COMSelectGroupBox.Controls.Add(this.COMComboBox);
            this.COMSelectGroupBox.Controls.Add(this.SendAndRecvLabel);
            this.COMSelectGroupBox.Location = new System.Drawing.Point(3, 3);
            this.COMSelectGroupBox.Name = "COMSelectGroupBox";
            this.COMSelectGroupBox.Size = new System.Drawing.Size(536, 105);
            this.COMSelectGroupBox.TabIndex = 0;
            this.COMSelectGroupBox.TabStop = false;
            // 
            // ExplainLabelSecondLine
            // 
            this.ExplainLabelSecondLine.AutoSize = true;
            this.ExplainLabelSecondLine.Location = new System.Drawing.Point(14, 85);
            this.ExplainLabelSecondLine.Name = "ExplainLabelSecondLine";
            this.ExplainLabelSecondLine.Size = new System.Drawing.Size(281, 12);
            this.ExplainLabelSecondLine.TabIndex = 3;
            this.ExplainLabelSecondLine.Text = "connection.See the Online Help(F1) for details";
            // 
            // ExplainLabelFirstLine
            // 
            this.ExplainLabelFirstLine.AutoSize = true;
            this.ExplainLabelFirstLine.Location = new System.Drawing.Point(14, 66);
            this.ExplainLabelFirstLine.Name = "ExplainLabelFirstLine";
            this.ExplainLabelFirstLine.Size = new System.Drawing.Size(299, 12);
            this.ExplainLabelFirstLine.TabIndex = 2;
            this.ExplainLabelFirstLine.Text = "Choose a COM port (e.g.COM3) or specify a network";
            // 
            // COMComboBox
            // 
            this.COMComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMComboBox.FormattingEnabled = true;
            this.COMComboBox.Location = new System.Drawing.Point(16, 32);
            this.COMComboBox.Name = "COMComboBox";
            this.COMComboBox.Size = new System.Drawing.Size(162, 20);
            this.COMComboBox.TabIndex = 1;
            // 
            // SendAndRecvLabel
            // 
            this.SendAndRecvLabel.AutoSize = true;
            this.SendAndRecvLabel.Location = new System.Drawing.Point(14, 17);
            this.SendAndRecvLabel.Name = "SendAndRecvLabel";
            this.SendAndRecvLabel.Size = new System.Drawing.Size(131, 12);
            this.SendAndRecvLabel.TabIndex = 0;
            this.SendAndRecvLabel.Text = "Send/Receive on Comm.";
            // 
            // ComSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.COMPanel);
            this.Name = "ComSetting";
            this.Size = new System.Drawing.Size(648, 353);
            this.Load += new System.EventHandler(this.ComSetting_Load);
            this.COMPanel.ResumeLayout(false);
            this.COMSettingsGroupBox.ResumeLayout(false);
            this.COMSettingsGroupBox.PerformLayout();
            this.COMSelectGroupBox.ResumeLayout(false);
            this.COMSelectGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel COMPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.GroupBox COMSettingsGroupBox;
        private System.Windows.Forms.ComboBox StopBitsComboBox;
        private System.Windows.Forms.ComboBox DataBitsComboBox;
        private System.Windows.Forms.ComboBox ParityErrorCharComboBox;
        private System.Windows.Forms.ComboBox ParityComboBox;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.Label StopBitsLabel;
        private System.Windows.Forms.Label DataBitsLabel;
        private System.Windows.Forms.Label ParityErrorCharLabel;
        private System.Windows.Forms.Label ParityLabel;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.GroupBox COMSelectGroupBox;
        private System.Windows.Forms.Label ExplainLabelSecondLine;
        private System.Windows.Forms.Label ExplainLabelFirstLine;
        private System.Windows.Forms.ComboBox COMComboBox;
        private System.Windows.Forms.Label SendAndRecvLabel;
    }
}
