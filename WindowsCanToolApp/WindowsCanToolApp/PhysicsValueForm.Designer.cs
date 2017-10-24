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
            this.label1 = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.SaveValueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Input PhysicValue ";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(12, 33);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(153, 21);
            this.InputTextBox.TabIndex = 1;
            // 
            // SaveValueButton
            // 
            this.SaveValueButton.Location = new System.Drawing.Point(197, 29);
            this.SaveValueButton.Name = "SaveValueButton";
            this.SaveValueButton.Size = new System.Drawing.Size(75, 23);
            this.SaveValueButton.TabIndex = 2;
            this.SaveValueButton.Text = "SaveValue";
            this.SaveValueButton.UseVisualStyleBackColor = true;
            this.SaveValueButton.Click += new System.EventHandler(this.SaveValue_Click);
            // 
            // PhysicsValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 64);
            this.Controls.Add(this.SaveValueButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.label1);
            this.Name = "PhysicsValueForm";
            this.Text = "PhysicsValueForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhysicsValueForm_FormClosing);
            this.Load += new System.EventHandler(this.PhysicsValueForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button SaveValueButton;
    }
}