namespace WindowsFormsApp1.CustomViews
{
    partial class AccInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Signup = new System.Windows.Forms.Button();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.roleTxt = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.pwlabel = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(189, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(189, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(189, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(189, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "RoleId";
            // 
            // Signup
            // 
            this.Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Signup.Location = new System.Drawing.Point(313, 224);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(132, 29);
            this.Signup.TabIndex = 28;
            this.Signup.Text = "Log out";
            this.Signup.UseVisualStyleBackColor = true;
            this.Signup.Click += new System.EventHandler(this.Log_outClick);
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameTxt.Location = new System.Drawing.Point(278, 14);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(145, 26);
            this.nameTxt.TabIndex = 29;
            // 
            // surnameTxt
            // 
            this.surnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.surnameTxt.Location = new System.Drawing.Point(278, 53);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(145, 26);
            this.surnameTxt.TabIndex = 30;
            // 
            // ageTxt
            // 
            this.ageTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ageTxt.Location = new System.Drawing.Point(278, 125);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(145, 26);
            this.ageTxt.TabIndex = 31;
            // 
            // roleTxt
            // 
            this.roleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.roleTxt.Location = new System.Drawing.Point(278, 165);
            this.roleTxt.Name = "roleTxt";
            this.roleTxt.Size = new System.Drawing.Size(145, 26);
            this.roleTxt.TabIndex = 32;
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateBtn.Location = new System.Drawing.Point(175, 224);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(132, 29);
            this.updateBtn.TabIndex = 33;
            this.updateBtn.Text = "Update info";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // pwlabel
            // 
            this.pwlabel.AutoSize = true;
            this.pwlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pwlabel.Location = new System.Drawing.Point(189, 92);
            this.pwlabel.Name = "pwlabel";
            this.pwlabel.Size = new System.Drawing.Size(78, 20);
            this.pwlabel.TabIndex = 34;
            this.pwlabel.Text = "Password";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordTxt.Location = new System.Drawing.Point(278, 89);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(145, 26);
            this.passwordTxt.TabIndex = 35;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // AccInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.pwlabel);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.roleTxt);
            this.Controls.Add(this.ageTxt);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AccInfo";
            this.Size = new System.Drawing.Size(698, 362);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.TextBox roleTxt;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label pwlabel;
        private System.Windows.Forms.TextBox passwordTxt;
    }
}
