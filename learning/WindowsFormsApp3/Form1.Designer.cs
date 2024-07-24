namespace WindowsFormsApp3
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.rdbtnR = new System.Windows.Forms.RadioButton();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.rdbtnY = new System.Windows.Forms.RadioButton();
            this.rdbtnK = new System.Windows.Forms.RadioButton();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(321, 165);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(144, 57);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "בדיקת סטטוס";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // rdbtnR
            // 
            this.rdbtnR.AutoSize = true;
            this.rdbtnR.Location = new System.Drawing.Point(128, 143);
            this.rdbtnR.Name = "rdbtnR";
            this.rdbtnR.Size = new System.Drawing.Size(114, 24);
            this.rdbtnR.TabIndex = 1;
            this.rdbtnR.TabStop = true;
            this.rdbtnR.Text = "רשות הרבים";
            this.rdbtnR.UseVisualStyleBackColor = true;
            this.rdbtnR.CheckedChanged += new System.EventHandler(this.rdbtnR_CheckedChanged);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(540, 141);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 26);
            this.txtHeight.TabIndex = 2;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // rdbtnY
            // 
            this.rdbtnY.AutoSize = true;
            this.rdbtnY.Location = new System.Drawing.Point(128, 251);
            this.rdbtnY.Name = "rdbtnY";
            this.rdbtnY.Size = new System.Drawing.Size(111, 24);
            this.rdbtnY.TabIndex = 3;
            this.rdbtnY.TabStop = true;
            this.rdbtnY.Text = "רשות היחיד";
            this.rdbtnY.UseVisualStyleBackColor = true;
            this.rdbtnY.CheckedChanged += new System.EventHandler(this.rdbtnY_CheckedChanged);
            // 
            // rdbtnK
            // 
            this.rdbtnK.AutoSize = true;
            this.rdbtnK.Location = new System.Drawing.Point(128, 198);
            this.rdbtnK.Name = "rdbtnK";
            this.rdbtnK.Size = new System.Drawing.Size(85, 24);
            this.rdbtnK.TabIndex = 4;
            this.rdbtnK.TabStop = true;
            this.rdbtnK.Text = "כרמלית";
            this.rdbtnK.UseVisualStyleBackColor = true;
            this.rdbtnK.CheckedChanged += new System.EventHandler(this.rdbtnK_CheckedChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(540, 198);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 26);
            this.txtWidth.TabIndex = 5;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(383, 362);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 20);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "סטטוס";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.rdbtnK);
            this.Controls.Add(this.rdbtnY);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.rdbtnR);
            this.Controls.Add(this.btnEnter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.RadioButton rdbtnR;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.RadioButton rdbtnY;
        private System.Windows.Forms.RadioButton rdbtnK;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblStatus;
    }
}

