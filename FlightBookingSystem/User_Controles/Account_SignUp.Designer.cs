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
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            NameSingUpTxtBox = new TextBox();
            SurnameSingUpTxtBox = new TextBox();
            AgeSingUpTxtBox = new TextBox();
            BackBtn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(263, 134);
            button1.Name = "button1";
            button1.Size = new Size(121, 31);
            button1.TabIndex = 10;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(189, 87);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 8;
            label4.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(189, 54);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 7;
            label3.Text = "Surname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(189, 21);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // NameSingUpTxtBox
            // 
            NameSingUpTxtBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NameSingUpTxtBox.Location = new Point(274, 18);
            NameSingUpTxtBox.Name = "NameSingUpTxtBox";
            NameSingUpTxtBox.Size = new Size(154, 27);
            NameSingUpTxtBox.TabIndex = 11;
            // 
            // SurnameSingUpTxtBox
            // 
            SurnameSingUpTxtBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SurnameSingUpTxtBox.Location = new Point(274, 54);
            SurnameSingUpTxtBox.Name = "SurnameSingUpTxtBox";
            SurnameSingUpTxtBox.Size = new Size(154, 27);
            SurnameSingUpTxtBox.TabIndex = 12;
            // 
            // AgeSingUpTxtBox
            // 
            AgeSingUpTxtBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AgeSingUpTxtBox.Location = new Point(274, 87);
            AgeSingUpTxtBox.Name = "AgeSingUpTxtBox";
            AgeSingUpTxtBox.Size = new Size(154, 27);
            AgeSingUpTxtBox.TabIndex = 13;
            // 
            // BackBtn
            // 
            BackBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BackBtn.Location = new Point(600, 11);
            BackBtn.Name = "Login";
            BackBtn.Size = new Size(45, 41);
            BackBtn.TabIndex = 14;
            BackBtn.Text = "<";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // Account_SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BackBtn);
            Controls.Add(AgeSingUpTxtBox);
            Controls.Add(SurnameSingUpTxtBox);
            Controls.Add(NameSingUpTxtBox);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Account_SignUp";
            Size = new Size(656, 418);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox NameSingUpTxtBox;
        private TextBox SurnameSingUpTxtBox;
        private TextBox AgeSingUpTxtBox;
        private Button BackBtn;
    }
}
