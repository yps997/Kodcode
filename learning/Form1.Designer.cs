namespace learning
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.inputVar = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.massage = new System.Windows.Forms.TextBox();
            this.btnDog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "names";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 3;
            this.button2.Text = "name";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inputVar
            // 
            this.inputVar.Location = new System.Drawing.Point(203, 22);
            this.inputVar.Name = "inputVar";
            this.inputVar.Size = new System.Drawing.Size(222, 26);
            this.inputVar.TabIndex = 4;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(258, 63);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 75);
            this.enter.TabIndex = 5;
            this.enter.Text = "enter";
            this.enter.UseVisualStyleBackColor = true;
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(453, 35);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(75, 75);
            this.btnStudents.TabIndex = 6;
            this.btnStudents.Text = "students";
            this.btnStudents.UseVisualStyleBackColor = true;
            // 
            // massage
            // 
            this.massage.Location = new System.Drawing.Point(12, 158);
            this.massage.Name = "massage";
            this.massage.Size = new System.Drawing.Size(416, 26);
            this.massage.TabIndex = 7;
            // 
            // btnDog
            // 
            this.btnDog.Location = new System.Drawing.Point(634, 215);
            this.btnDog.Name = "btnDog";
            this.btnDog.Size = new System.Drawing.Size(75, 75);
            this.btnDog.TabIndex = 8;
            this.btnDog.Text = "new dog";
            this.btnDog.UseVisualStyleBackColor = true;
            this.btnDog.Click += new System.EventHandler(this.btnDog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDog);
            this.Controls.Add(this.massage);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.inputVar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inputVar;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.TextBox massage;
        private System.Windows.Forms.Button btnDog;
    }
}

