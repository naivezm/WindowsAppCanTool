namespace WindowsCanToolApp
{
    partial class PhysicsValueForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveValueButton = new System.Windows.Forms.Button();
            this.PhyDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PhyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveValueButton
            // 
            this.SaveValueButton.Location = new System.Drawing.Point(438, 259);
            this.SaveValueButton.Name = "SaveValueButton";
            this.SaveValueButton.Size = new System.Drawing.Size(75, 23);
            this.SaveValueButton.TabIndex = 2;
            this.SaveValueButton.Text = "SaveValue";
            this.SaveValueButton.UseVisualStyleBackColor = true;
            this.SaveValueButton.Click += new System.EventHandler(this.SaveValue_Click);
            // 
            // PhyDataGridView
            // 
            this.PhyDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.PhyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhyDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PhyDataGridView.Location = new System.Drawing.Point(12, 12);
            this.PhyDataGridView.Name = "PhyDataGridView";
            this.PhyDataGridView.RowTemplate.Height = 23;
            this.PhyDataGridView.Size = new System.Drawing.Size(512, 241);
            this.PhyDataGridView.TabIndex = 3;
            // 
            // PhysicsValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 294);
            this.Controls.Add(this.PhyDataGridView);
            this.Controls.Add(this.SaveValueButton);
            this.Name = "PhysicsValueForm";
            this.Text = "PhysicsValueForm";
            this.Load += new System.EventHandler(this.PhysicsValueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveValueButton;
        private System.Windows.Forms.DataGridView PhyDataGridView;
    }
}