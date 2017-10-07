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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本设置ToolStripMenuItem,
            this.cAN信息显示ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // 
            // cAN信息设置ToolStripMenuItem
            // 
            this.cAN信息设置ToolStripMenuItem.Name = "cAN信息设置ToolStripMenuItem";
            this.cAN信息设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cAN信息设置ToolStripMenuItem.Text = "CAN信息设置";
            // 
            // cAN信息显示ToolStripMenuItem
            // 
            this.cAN信息显示ToolStripMenuItem.Name = "cAN信息显示ToolStripMenuItem";
            this.cAN信息显示ToolStripMenuItem.Size = new System.Drawing.Size(94, 21);
            this.cAN信息显示ToolStripMenuItem.Text = "CAN信息显示";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基本设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOM口设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAN信息设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAN信息显示ToolStripMenuItem;
    }
}

