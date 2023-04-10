using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
namespace PL_FlightBookingSystem
{
    partial class Account_SignUp
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SinUsernameTxt = new System.Windows.Forms.TextBox();
            this.SinSurnameTxt = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.Signup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SinPasswdTxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Login = new System.Windows.Forms.Button();
            this.LogPasswordTxt = new System.Windows.Forms.TextBox();
            this.LogUsernameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(386, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(386, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(386, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // SinUsernameTxt
            // 
            this.SinUsernameTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SinUsernameTxt.Location = new System.Drawing.Point(481, 14);
            this.SinUsernameTxt.Name = "SinUsernameTxt";
            this.SinUsernameTxt.Size = new System.Drawing.Size(175, 29);
            this.SinUsernameTxt.TabIndex = 23;
            // 
            // SinSurnameTxt
            // 
            this.SinSurnameTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SinSurnameTxt.Location = new System.Drawing.Point(481, 51);
            this.SinSurnameTxt.Name = "SinSurnameTxt";
            this.SinSurnameTxt.Size = new System.Drawing.Size(175, 29);
            this.SinSurnameTxt.TabIndex = 24;
            // 
            // AgeBox
            // 
            this.AgeBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AgeBox.Location = new System.Drawing.Point(481, 121);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(175, 29);
            this.AgeBox.TabIndex = 26;
            // 
            // Signup
            // 
            this.Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Signup.Location = new System.Drawing.Point(466, 176);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(132, 29);
            this.Signup.TabIndex = 27;
            this.Signup.Text = "Sign up";
            this.Signup.UseVisualStyleBackColor = true;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(386, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Password";
            // 
            // SinPasswdTxt
            // 
            this.SinPasswdTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SinPasswdTxt.Location = new System.Drawing.Point(481, 86);
            this.SinPasswdTxt.Name = "SinPasswdTxt";
            this.SinPasswdTxt.Size = new System.Drawing.Size(175, 29);
            this.SinPasswdTxt.TabIndex = 25;
            this.SinPasswdTxt.UseSystemPasswordChar = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Login.Location = new System.Drawing.Point(87, 121);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(132, 29);
            this.Login.TabIndex = 22;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // LogPasswordTxt
            // 
            this.LogPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LogPasswordTxt.Location = new System.Drawing.Point(133, 63);
            this.LogPasswordTxt.Name = "LogPasswordTxt";
            this.LogPasswordTxt.Size = new System.Drawing.Size(152, 26);
            this.LogPasswordTxt.TabIndex = 21;
            this.LogPasswordTxt.UseSystemPasswordChar = true;
            // 
            // LogUsernameTxt
            // 
            this.LogUsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LogUsernameTxt.Location = new System.Drawing.Point(133, 20);
            this.LogUsernameTxt.Name = "LogUsernameTxt";
            this.LogUsernameTxt.Size = new System.Drawing.Size(152, 26);
            this.LogUsernameTxt.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(33, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(33, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Username";
            // 
            // Account_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LogPasswordTxt);
            this.Controls.Add(this.LogUsernameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SinPasswdTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.SinSurnameTxt);
            this.Controls.Add(this.SinUsernameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Account_SignUp";
            this.Size = new System.Drawing.Size(698, 362);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox SinUsernameTxt;
        private TextBox SinSurnameTxt;
        private TextBox AgeBox;
        private Button Signup;
        private Label label1;
        private TextBox SinPasswdTxt;
        private ContextMenuStrip contextMenuStrip1;
        private Button Login;
        private TextBox LogPasswordTxt;
        private TextBox LogUsernameTxt;
        private Label label5;
        private Label label6;
    }
}
