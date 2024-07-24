namespace WindowsFormsApp2
{
    partial class Form1
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
            this.txtbox = new System.Windows.Forms.TextBox();
            this.validateAge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(244, 59);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(249, 26);
            this.txtbox.TabIndex = 0;
            this.txtbox.TextChanged += new System.EventHandler(this.txtbox_TextChanged);
            // 
            // validateAge
            // 
            this.validateAge.Location = new System.Drawing.Point(274, 217);
            this.validateAge.Name = "validateAge";
            this.validateAge.Size = new System.Drawing.Size(189, 58);
            this.validateAge.TabIndex = 1;
            this.validateAge.Text = "enter";
            this.validateAge.UseVisualStyleBackColor = true;
            this.validateAge.Click += new System.EventHandler(this.validateAge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validateAge);
            this.Controls.Add(this.txtbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button validateAge;
    }
}

