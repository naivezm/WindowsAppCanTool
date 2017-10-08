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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基本设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM口设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAN信息设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAN信息显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAN原始数据显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAN信号仪表盘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAN信号曲线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAN信息发送ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.COMpanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Explainlabel2 = new System.Windows.Forms.Label();
            this.Explainlabel1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SendAndRecvlabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.Mainpanel.SuspendLayout();
            this.COMpanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本设置ToolStripMenuItem,
            this.cAN信息显示ToolStripMenuItem,
            this.cAN信息发送ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // Mainpanel
            // 
            
            this.Mainpanel.Location = new System.Drawing.Point(0, 29);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(563, 332);
            this.Mainpanel.TabIndex = 1;
            this.Mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Mainpanel_Paint);
            // 
            // COMpanel
            // 
            this.COMpanel.Controls.Add(this.button3);
            this.COMpanel.Controls.Add(this.button2);
            this.COMpanel.Controls.Add(this.button1);
            this.COMpanel.Controls.Add(this.groupBox2);
            this.COMpanel.Controls.Add(this.groupBox1);
            this.COMpanel.Location = new System.Drawing.Point(12, -1);
            this.COMpanel.Name = "COMpanel";
            this.COMpanel.Size = new System.Drawing.Size(545, 333);
            this.COMpanel.TabIndex = 0;
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
            this.groupBox2.Controls.Add(this.comboBox6);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
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
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "1"});
            this.comboBox6.Location = new System.Drawing.Point(392, 72);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 20);
            this.comboBox6.TabIndex = 9;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "8"});
            this.comboBox5.Location = new System.Drawing.Point(392, 34);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 20);
            this.comboBox5.TabIndex = 8;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(148, 107);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 20);
            this.comboBox4.TabIndex = 7;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "ODD",
            "EVEN",
            "MARK",
            "SPACE",
            "NONE"});
            this.comboBox3.Location = new System.Drawing.Point(148, 72);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(148, 34);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 5;
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
            this.groupBox1.Controls.Add(this.comboBox1);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 20);
            this.comboBox1.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 358);
            this.Controls.Add(this.Mainpanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Windows App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Mainpanel.ResumeLayout(false);
            this.COMpanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基本设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOM口设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAN信息设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAN信息显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAN信息发送ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAN原始数据显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAN信号仪表盘ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAN信号曲线ToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Mainpanel;
        private System.Windows.Forms.Panel COMpanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Explainlabel2;
        private System.Windows.Forms.Label Explainlabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label SendAndRecvlabel;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

