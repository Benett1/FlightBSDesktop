using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
namespace PL_FlightBookingSystem
{
    partial class Account
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Login = new System.Windows.Forms.Button();
            this.LogPasswordTxt = new System.Windows.Forms.TextBox();
            this.LogUsernameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Login.Location = new System.Drawing.Point(262, 145);
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
            this.LogPasswordTxt.Location = new System.Drawing.Point(283, 100);
            this.LogPasswordTxt.Name = "LogPasswordTxt";
            this.LogPasswordTxt.Size = new System.Drawing.Size(152, 26);
            this.LogPasswordTxt.TabIndex = 21;
            this.LogPasswordTxt.UseSystemPasswordChar = true;
            // 
            // LogUsernameTxt
            // 
            this.LogUsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LogUsernameTxt.Location = new System.Drawing.Point(283, 61);
            this.LogUsernameTxt.Name = "LogUsernameTxt";
            this.LogUsernameTxt.Size = new System.Drawing.Size(152, 26);
            this.LogUsernameTxt.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(218, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(218, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Username";
            // 
            // signUpBtn
            // 
            this.signUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.signUpBtn.Location = new System.Drawing.Point(262, 180);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(132, 29);
            this.signUpBtn.TabIndex = 23;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LogPasswordTxt);
            this.Controls.Add(this.LogUsernameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "Account";
            this.Size = new System.Drawing.Size(698, 362);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Button Login;
        private TextBox LogPasswordTxt;
        private TextBox LogUsernameTxt;
        private Label label5;
        private Label label6;
        private Button signUpBtn;
    }
}
