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
            this.cAN信息设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAN信息显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAN原始数据显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAN信号仪表盘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAN信号曲线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAN信息发送ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SendReceivePanel = new System.Windows.Forms.Panel();
            this.SendButton = new System.Windows.Forms.Button();
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.ReceiveTextBox = new System.Windows.Forms.TextBox();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.MenuStrip.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SendReceivePanel.SuspendLayout();
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
            this.MenuStrip.Size = new System.Drawing.Size(563, 25);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            this.MenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 基本设置ToolStripMenuItem
            // 
            this.基本设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOM口设置ToolStripMenuItem,
            this.cAN信息设置ToolStripMenuItem});
            this.基本设置ToolStripMenuItem.Name = "基本设置ToolStripMenuItem";
            this.基本设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.基本设置ToolStripMenuItem.Text = "基本设置";
            // 
            // cOM口设置ToolStripMenuItem
            // 
            this.cOM口设置ToolStripMenuItem.Name = "cOM口设置ToolStripMenuItem";
            this.cOM口设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cOM口设置ToolStripMenuItem.Text = "COM口设置";
            this.cOM口设置ToolStripMenuItem.Click += new System.EventHandler(this.cOM口设置ToolStripMenuItem_Click);
            // 
            // cAN信息设置ToolStripMenuItem
            // 
            this.cAN信息设置ToolStripMenuItem.Name = "cAN信息设置ToolStripMenuItem";
            this.cAN信息设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cAN信息设置ToolStripMenuItem.Text = "CAN信息设置";
            this.cAN信息设置ToolStripMenuItem.Click += new System.EventHandler(this.cAN信息设置ToolStripMenuItem_Click);
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
            // 
            // cAN原始数据显示ToolStripMenuItem
            // 
            this.cAN原始数据显示ToolStripMenuItem.Name = "cAN原始数据显示ToolStripMenuItem";
            this.cAN原始数据显示ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cAN原始数据显示ToolStripMenuItem.Text = "CAN原始数据显示";
            // 
            // cAN信号仪表盘ToolStripMenuItem
            // 
            this.cAN信号仪表盘ToolStripMenuItem.Name = "cAN信号仪表盘ToolStripMenuItem";
            this.cAN信号仪表盘ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cAN信号仪表盘ToolStripMenuItem.Text = "CAN信号仪表盘";
            // 
            // cAN信号曲线ToolStripMenuItem
            // 
            this.cAN信号曲线ToolStripMenuItem.Name = "cAN信号曲线ToolStripMenuItem";
            this.cAN信号曲线ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cAN信号曲线ToolStripMenuItem.Text = "CAN信号曲线";
            // 
            // cAN信息发送ToolStripMenuItem
            // 
            this.cAN信息发送ToolStripMenuItem.Name = "cAN信息发送ToolStripMenuItem";
            this.cAN信息发送ToolStripMenuItem.Size = new System.Drawing.Size(94, 21);
            this.cAN信息发送ToolStripMenuItem.Text = "CAN信息发送";
            this.cAN信息发送ToolStripMenuItem.Click += new System.EventHandler(this.cAN信息发送ToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
<<<<<<< HEAD
            this.Mainpanel.Location = new System.Drawing.Point(0, 29);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(563, 332);
            this.Mainpanel.TabIndex = 1;
            this.Mainpanel.Controls.Add(SendReceivepanel);
           // this.Mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Mainpanel_Paint);
=======
            //this.MainPanel.Controls.Add(this.SendReceivePanel);
            this.MainPanel.Location = new System.Drawing.Point(0, 29);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(563, 332);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Mainpanel_Paint);
>>>>>>> 6c00fe8b22e9c215600f71a80e984e18432b6821
            // 
            // SendReceivePanel
            // 
            this.SendReceivePanel.Controls.Add(this.SendButton);
            this.SendReceivePanel.Controls.Add(this.SendTextBox);
            this.SendReceivePanel.Controls.Add(this.ReceiveTextBox);
            this.SendReceivePanel.Location = new System.Drawing.Point(3, 0);
            this.SendReceivePanel.Name = "SendReceivePanel";
            this.SendReceivePanel.Size = new System.Drawing.Size(557, 300);
            this.SendReceivePanel.TabIndex = 0;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(488, 147);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(60, 114);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "button4";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // SendTextBox
            // 
            this.SendTextBox.Location = new System.Drawing.Point(215, 147);
            this.SendTextBox.Multiline = true;
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(267, 114);
            this.SendTextBox.TabIndex = 1;
            // 
            // ReceiveTextBox
            // 
            this.ReceiveTextBox.Location = new System.Drawing.Point(215, 3);
            this.ReceiveTextBox.Multiline = true;
            this.ReceiveTextBox.Name = "ReceiveTextBox";
            this.ReceiveTextBox.Size = new System.Drawing.Size(333, 136);
            this.ReceiveTextBox.TabIndex = 0;
            // 
            // SerialPort
            // 
            this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sPort_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 358);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "Windows App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.SendReceivePanel.ResumeLayout(false);
            this.SendReceivePanel.PerformLayout();
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
        private System.Windows.Forms.TextBox SendTextBox;
        private System.Windows.Forms.TextBox ReceiveTextBox;
        private System.IO.Ports.SerialPort SerialPort;
    }
}

