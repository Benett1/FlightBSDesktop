namespace PL_FlightBookingSystem
{
    partial class Account_Login
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
            label1 = new Label();
            label2 = new Label();
            NameLoginTxtBox = new TextBox();
            PasswordLoginTxtBox = new TextBox();
            Signup = new Button();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(182, 37);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(182, 80);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // NameLoginTxtBox
            // 
            NameLoginTxtBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NameLoginTxtBox.Location = new Point(280, 34);
            NameLoginTxtBox.Name = "NameLoginTxtBox";
            NameLoginTxtBox.Size = new Size(160, 27);
            NameLoginTxtBox.TabIndex = 2;
            // 
            // PasswordLoginTxtBox
            // 
            PasswordLoginTxtBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLoginTxtBox.Location = new Point(280, 77);
            PasswordLoginTxtBox.Name = "PasswordLoginTxtBox";
            PasswordLoginTxtBox.Size = new Size(160, 27);
            PasswordLoginTxtBox.TabIndex = 3;
            // 
            // Signup
            // 
            Signup.Location = new Point(263, 169);
            Signup.Name = "Signup";
            Signup.Size = new Size(121, 31);
            Signup.TabIndex = 11;
            Signup.Text = "Sign Up";
            Signup.UseVisualStyleBackColor = true;
            Signup.Click += SignupBtn_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(263, 132);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(121, 31);
            LoginBtn.TabIndex = 12;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += button1_Click;
            // 
            // Account_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LoginBtn);
            Controls.Add(Signup);
            Controls.Add(PasswordLoginTxtBox);
            Controls.Add(NameLoginTxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Account_Login";
            Size = new Size(656, 418);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NameLoginTxtBox;
        private TextBox PasswordLoginTxtBox;
        private Button Signup;
        private Button LoginBtn;
    }
}
