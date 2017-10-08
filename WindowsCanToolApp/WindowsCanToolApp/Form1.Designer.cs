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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(665, 25);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 343);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 343);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(16, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 115);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(16, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(603, 130);
            this.panel4.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(521, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Windows App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem cAN原始数据显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAN信号仪表盘ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAN信号曲线ToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}

