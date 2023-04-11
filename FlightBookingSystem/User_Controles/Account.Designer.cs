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
            label1 = new Label();
            account_Login1 = new Account_Login();
            account_SignUp1 = new Account_SignUp();
            GlobalState.setInstance(account_Login1);
            GlobalState.setInstance(account_SignUp1);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(353, 22);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 0;
            label1.Text = "Account";
            // 
            // account_Login1
            // 
            account_Login1.Anchor = AnchorStyles.Top;
            account_Login1.Location = new Point(75, 53);
            account_Login1.Name = "Login";
            account_Login1.Size = new Size(656, 490);
            account_Login1.TabIndex = 1;
            // 
            // account_SignUp1
            // 
            account_SignUp1.Anchor = AnchorStyles.Top;
            account_SignUp1.Location = new Point(87, 72);
            account_SignUp1.Name = "Signup";
            account_SignUp1.Size = new Size(656, 418);
            account_SignUp1.TabIndex = 2;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(account_SignUp1);
            Controls.Add(account_Login1);
            Controls.Add(label1);
            Name = "Account";
            Size = new Size(824, 511);
            Load += Account_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Account_Login account_Login1;
        private Account_SignUp account_SignUp1;
    }
}
