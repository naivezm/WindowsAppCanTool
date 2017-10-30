namespace WindowsCanToolApp
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.基本设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM口设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAN信息显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAN原始数据显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAN信号仪表盘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAN信号曲线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAN信息发送ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAN信息设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DataDisplayPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SendReceivePanel = new System.Windows.Forms.Panel();
            this.TreeView = new System.Windows.Forms.TreeView();
            this.SendButton = new System.Windows.Forms.Button();
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.ReceiveTextBox = new System.Windows.Forms.TextBox();
            this.COMPanel = new System.Windows.Forms.Panel();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.COMSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.StopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.DataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.ParityComboBox = new System.Windows.Forms.ComboBox();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.StopBitsLabel = new System.Windows.Forms.Label();
            this.DataBitsLabel = new System.Windows.Forms.Label();
            this.ParityLabel = new System.Windows.Forms.Label();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.COMSelectGroupBox = new System.Windows.Forms.GroupBox();
            this.ExplainLabelSecondLine = new System.Windows.Forms.Label();
            this.ExplainLabelFirstLine = new System.Windows.Forms.Label();
            this.COMComboBox = new System.Windows.Forms.ComboBox();
            this.SendAndRecvLabel = new System.Windows.Forms.Label();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.MenuStrip.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.DataDisplayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SendReceivePanel.SuspendLayout();
            this.COMPanel.SuspendLayout();
            this.COMSettingsGroupBox.SuspendLayout();
            this.COMSelectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本设置ToolStripMenuItem,
            this.cAN信息显示ToolStripMenuItem,
            this.cAN信息发送ToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(580, 25);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            this.MenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 基本设置ToolStripMenuItem
            // 
            this.基本设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOM口设置ToolStripMenuItem});
            this.基本设置ToolStripMenuItem.Name = "基本设置ToolStripMenuItem";
            this.基本设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.基本设置ToolStripMenuItem.Text = "基本设置";
            this.基本设置ToolStripMenuItem.Click += new System.EventHandler(this.基本设置ToolStripMenuItem_Click);
            // 
            // cOM口设置ToolStripMenuItem
            // 
            this.cOM口设置ToolStripMenuItem.Name = "cOM口设置ToolStripMenuItem";
            this.cOM口设置ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cOM口设置ToolStripMenuItem.Text = "COM口设置";
            this.cOM口设置ToolStripMenuItem.Click += new System.EventHandler(this.cOM口设置ToolStripMenuItem_Click);
            // 
            // cAN信息显示ToolStripMenuItem
            // 
            this.cAN信息显示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cAN原始数据显示ToolStripMenuItem,
            this.cAN信号仪表盘ToolStripMenuItem,
            this.cAN信号曲线ToolStripMenuItem});
            this.cAN信息显示ToolStripMenuItem.Name = "cAN信息显示ToolStripMenuItem";
            this.cAN信息显示ToolStripMenuItem.Size = new System.Drawing.Size(94, 21);
            this.cAN信息显示ToolStripMenuItem.Text = "CAN信息显示";
            this.cAN信息显示ToolStripMenuItem.Click += new System.EventHandler(this.cAN信息显示ToolStripMenuItem_Click);
            // 
            // cAN原始数据显示ToolStripMenuItem
            // 
            this.cAN原始数据显示ToolStripMenuItem.Name = "cAN原始数据显示ToolStripMenuItem";
            this.cAN原始数据显示ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cAN原始数据显示ToolStripMenuItem.Text = "CAN原始数据显示";
            this.cAN原始数据显示ToolStripMenuItem.Click += new System.EventHandler(this.cAN原始数据显示ToolStripMenuItem_Click);
            // 
            // cAN信号仪表盘ToolStripMenuItem
            // 
            this.cAN信号仪表盘ToolStripMenuItem.Name = "cAN信号仪表盘ToolStripMenuItem";
            this.cAN信号仪表盘ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cAN信号仪表盘ToolStripMenuItem.Text = "CAN信号仪表盘";
            this.cAN信号仪表盘ToolStripMenuItem.Click += new System.EventHandler(this.cAN信号仪表盘ToolStripMenuItem_Click);
            // 
            // cAN信号曲线ToolStripMenuItem
            // 
            this.cAN信号曲线ToolStripMenuItem.Name = "cAN信号曲线ToolStripMenuItem";
            this.cAN信号曲线ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cAN信号曲线ToolStripMenuItem.Text = "CAN信号曲线";
            this.cAN信号曲线ToolStripMenuItem.Click += new System.EventHandler(this.cAN信号曲线ToolStripMenuItem_Click);
            // 
            // cAN信息发送ToolStripMenuItem
            // 
            this.cAN信息发送ToolStripMenuItem.Name = "cAN信息发送ToolStripMenuItem";
            this.cAN信息发送ToolStripMenuItem.Size = new System.Drawing.Size(94, 21);
            this.cAN信息发送ToolStripMenuItem.Text = "CAN信息接发";
            this.cAN信息发送ToolStripMenuItem.Click += new System.EventHandler(this.cAN信息发送ToolStripMenuItem_Click);
            // 
            // cAN信息设置ToolStripMenuItem
            // 
            this.cAN信息设置ToolStripMenuItem.Name = "cAN信息设置ToolStripMenuItem";
            this.cAN信息设置ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // MainPanel
            // 
            //this.MainPanel.Controls.Add(this.DataDisplayPanel);
            this.MainPanel.Location = new System.Drawing.Point(0, 29);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(580, 332);
            this.MainPanel.TabIndex = 1;
            // 
            // DataDisplayPanel
            // 
            this.DataDisplayPanel.Controls.Add(this.dataGridView1);
            this.DataDisplayPanel.Location = new System.Drawing.Point(12, 12);
            this.DataDisplayPanel.Name = "DataDisplayPanel";
            this.DataDisplayPanel.Size = new System.Drawing.Size(568, 308);
            this.DataDisplayPanel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(565, 302);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // SendReceivePanel
            // 
            this.SendReceivePanel.Controls.Add(this.TreeView);
            this.SendReceivePanel.Controls.Add(this.SendButton);
            this.SendReceivePanel.Controls.Add(this.SendTextBox);
            this.SendReceivePanel.Controls.Add(this.ReceiveTextBox);
            this.SendReceivePanel.Location = new System.Drawing.Point(3, 0);
            this.SendReceivePanel.Name = "SendReceivePanel";
            this.SendReceivePanel.Size = new System.Drawing.Size(557, 302);
            this.SendReceivePanel.TabIndex = 0;
            // 
            // TreeView
            // 
            this.TreeView.Location = new System.Drawing.Point(3, 3);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(178, 261);
            this.TreeView.TabIndex = 3;
            this.TreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            this.TreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseDoubleClick);
            this.TreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseDown);
            this.TreeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseUp);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(494, 237);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(60, 27);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // SendTextBox
            // 
            this.SendTextBox.Location = new System.Drawing.Point(237, 145);
            this.SendTextBox.Multiline = true;
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(251, 119);
            this.SendTextBox.TabIndex = 1;
            // 
            // ReceiveTextBox
            // 
            this.ReceiveTextBox.Location = new System.Drawing.Point(236, 3);
            this.ReceiveTextBox.Multiline = true;
            this.ReceiveTextBox.Name = "ReceiveTextBox";
            this.ReceiveTextBox.Size = new System.Drawing.Size(321, 131);
            this.ReceiveTextBox.TabIndex = 0;
            this.ReceiveTextBox.TextChanged += new System.EventHandler(this.ReceiveTextBox_TextChanged);
            // 
            // COMPanel
            // 
            this.COMPanel.Controls.Add(this.ConditionLabel);
            this.COMPanel.Controls.Add(this.CloseButton);
            this.COMPanel.Controls.Add(this.OpenButton);
            this.COMPanel.Controls.Add(this.COMSettingsGroupBox);
            this.COMPanel.Controls.Add(this.COMSelectGroupBox);
            this.COMPanel.Location = new System.Drawing.Point(18, 12);
            this.COMPanel.Name = "COMPanel";
            this.COMPanel.Size = new System.Drawing.Size(545, 308);
            this.COMPanel.TabIndex = 2;
            this.COMPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.COMPanel_Paint);
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(25, 265);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(0, 12);
            this.ConditionLabel.TabIndex = 4;
            // 
            // CloseButton
            // 
            this.CloseButton.Enabled = false;
            this.CloseButton.Location = new System.Drawing.Point(450, 254);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(301, 254);
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
            this.COMSettingsGroupBox.Controls.Add(this.ParityComboBox);
            this.COMSettingsGroupBox.Controls.Add(this.BaudRateComboBox);
            this.COMSettingsGroupBox.Controls.Add(this.StopBitsLabel);
            this.COMSettingsGroupBox.Controls.Add(this.DataBitsLabel);
            this.COMSettingsGroupBox.Controls.Add(this.ParityLabel);
            this.COMSettingsGroupBox.Controls.Add(this.BaudRateLabel);
            this.COMSettingsGroupBox.Location = new System.Drawing.Point(3, 126);
            this.COMSettingsGroupBox.Name = "COMSettingsGroupBox";
            this.COMSettingsGroupBox.Size = new System.Drawing.Size(536, 122);
            this.COMSettingsGroupBox.TabIndex = 1;
            this.COMSettingsGroupBox.TabStop = false;
            this.COMSettingsGroupBox.Text = "COM port Settings.";
            // 
            // StopBitsComboBox
            // 
            this.StopBitsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StopBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBitsComboBox.FormattingEnabled = true;
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
            this.DataBitsComboBox.Location = new System.Drawing.Point(392, 34);
            this.DataBitsComboBox.Name = "DataBitsComboBox";
            this.DataBitsComboBox.Size = new System.Drawing.Size(121, 20);
            this.DataBitsComboBox.TabIndex = 8;
            // 
            // ParityComboBox
            // 
            this.ParityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParityComboBox.FormattingEnabled = true;
            this.ParityComboBox.Location = new System.Drawing.Point(148, 72);
            this.ParityComboBox.Name = "ParityComboBox";
            this.ParityComboBox.Size = new System.Drawing.Size(121, 20);
            this.ParityComboBox.TabIndex = 6;
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.FormattingEnabled = true;
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
            // SerialPort
            // 
            this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 361);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "Windows App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.DataDisplayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.SendReceivePanel.ResumeLayout(false);
            this.SendReceivePanel.PerformLayout();
            this.COMPanel.ResumeLayout(false);
            this.COMPanel.PerformLayout();
            this.COMSettingsGroupBox.ResumeLayout(false);
            this.COMSettingsGroupBox.PerformLayout();
            this.COMSelectGroupBox.ResumeLayout(false);
            this.COMSelectGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 基本设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOM口设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAN信息设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAN信息显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAN信息发送ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAN原始数据显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAN信号仪表盘ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAN信号曲线ToolStripMenuItem;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SendReceivePanel;
        private System.Windows.Forms.Button SendButton;
        public System.Windows.Forms.TextBox SendTextBox;
        public System.Windows.Forms.TextBox ReceiveTextBox;
        public System.IO.Ports.SerialPort SerialPort;
        public System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.Panel DataDisplayPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Panel COMPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.GroupBox COMSettingsGroupBox;
        private System.Windows.Forms.ComboBox StopBitsComboBox;
        private System.Windows.Forms.ComboBox DataBitsComboBox;
        private System.Windows.Forms.ComboBox ParityComboBox;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.Label StopBitsLabel;
        private System.Windows.Forms.Label DataBitsLabel;
        private System.Windows.Forms.Label ParityLabel;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.GroupBox COMSelectGroupBox;
        private System.Windows.Forms.Label ExplainLabelSecondLine;
        private System.Windows.Forms.Label ExplainLabelFirstLine;
        private System.Windows.Forms.ComboBox COMComboBox;
        private System.Windows.Forms.Label SendAndRecvLabel;
        private System.Windows.Forms.Label ConditionLabel;
    }
}

