namespace WindowsFormsApp1.CustomViews
{
    partial class Signup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SinPasswdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.SinSurnameTxt = new System.Windows.Forms.TextBox();
            this.SinUsernameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SinPasswdTxt
            // 
            this.SinPasswdTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SinPasswdTxt.Location = new System.Drawing.Point(269, 121);
            this.SinPasswdTxt.Name = "SinPasswdTxt";
            this.SinPasswdTxt.Size = new System.Drawing.Size(175, 29);
            this.SinPasswdTxt.TabIndex = 34;
            this.SinPasswdTxt.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(212, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Password";
            // 
            // signUpBtn
            // 
            this.signUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.signUpBtn.Location = new System.Drawing.Point(269, 209);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(132, 29);
            this.signUpBtn.TabIndex = 36;
            this.signUpBtn.Text = "Sign up";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgeBox
            // 
            this.AgeBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AgeBox.Location = new System.Drawing.Point(269, 156);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(175, 29);
            this.AgeBox.TabIndex = 35;
            // 
            // SinSurnameTxt
            // 
            this.SinSurnameTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SinSurnameTxt.Location = new System.Drawing.Point(269, 86);
            this.SinSurnameTxt.Name = "SinSurnameTxt";
            this.SinSurnameTxt.Size = new System.Drawing.Size(175, 29);
            this.SinSurnameTxt.TabIndex = 33;
            // 
            // SinUsernameTxt
            // 
            this.SinUsernameTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SinUsernameTxt.Location = new System.Drawing.Point(269, 49);
            this.SinUsernameTxt.Name = "SinUsernameTxt";
            this.SinUsernameTxt.Size = new System.Drawing.Size(175, 29);
            this.SinUsernameTxt.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(212, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(212, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(212, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Name";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(118, 48);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(42, 30);
            this.backBtn.TabIndex = 37;
            this.backBtn.Text = "<";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.SinPasswdTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.SinSurnameTxt);
            this.Controls.Add(this.SinUsernameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Signup";
            this.Size = new System.Drawing.Size(698, 362);
            this.ResumeLayout(false);
            this.PerformLayout();
            GlobalState.setInstance(this);

        }

        #endregion

        private System.Windows.Forms.TextBox SinPasswdTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.TextBox SinSurnameTxt;
        private System.Windows.Forms.TextBox SinUsernameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backBtn;
    }
}
