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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameSingUpTxtBox = new System.Windows.Forms.TextBox();
            this.SurnameSingUpTxtBox = new System.Windows.Forms.TextBox();
            this.AgeSingUpTxtBox = new System.Windows.Forms.TextBox();
            this.Signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(152, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(152, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(152, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // NameSingUpTxtBox
            // 
            this.NameSingUpTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NameSingUpTxtBox.Location = new System.Drawing.Point(247, 17);
            this.NameSingUpTxtBox.Name = "NameSingUpTxtBox";
            this.NameSingUpTxtBox.Size = new System.Drawing.Size(133, 29);
            this.NameSingUpTxtBox.TabIndex = 11;
            // 
            // SurnameSingUpTxtBox
            // 
            this.SurnameSingUpTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SurnameSingUpTxtBox.Location = new System.Drawing.Point(247, 54);
            this.SurnameSingUpTxtBox.Name = "SurnameSingUpTxtBox";
            this.SurnameSingUpTxtBox.Size = new System.Drawing.Size(133, 29);
            this.SurnameSingUpTxtBox.TabIndex = 12;
            // 
            // AgeSingUpTxtBox
            // 
            this.AgeSingUpTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AgeSingUpTxtBox.Location = new System.Drawing.Point(247, 94);
            this.AgeSingUpTxtBox.Name = "AgeSingUpTxtBox";
            this.AgeSingUpTxtBox.Size = new System.Drawing.Size(133, 29);
            this.AgeSingUpTxtBox.TabIndex = 13;
            // 
            // Signup
            // 
            this.Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Signup.Location = new System.Drawing.Point(205, 140);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(132, 29);
            this.Signup.TabIndex = 14;
            this.Signup.Text = "Sign up";
            this.Signup.UseVisualStyleBackColor = true;
            // 
            // Account_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.AgeSingUpTxtBox);
            this.Controls.Add(this.SurnameSingUpTxtBox);
            this.Controls.Add(this.NameSingUpTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Account_SignUp";
            this.Size = new System.Drawing.Size(562, 362);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox NameSingUpTxtBox;
        private TextBox SurnameSingUpTxtBox;
        private TextBox AgeSingUpTxtBox;
        private Button Signup;
    }
}
