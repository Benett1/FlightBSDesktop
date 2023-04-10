using PL_FlightBookingSystem;
using System.Windows.Forms;

namespace FlightBookingSystem
{
    partial class FlightBookingSystem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip2 = new MenuStrip();
            homeToolStripMenuItem1 = new ToolStripMenuItem();
            settingsToolStripMenuItem1 = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            Home = new Home();
            Settings = new Settings();
            Account = new Account();
            GlobalState.StateInstances.Add(Home);
            GlobalState.StateInstances.Add(Settings);
            GlobalState.StateInstances.Add(Account);
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip2.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem1, settingsToolStripMenuItem1, accountToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(879, 28);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // homeToolStripMenuItem1
            // 
            homeToolStripMenuItem1.Name = "homeToolStripMenuItem1";
            homeToolStripMenuItem1.Size = new Size(62, 24);
            homeToolStripMenuItem1.Text = "Home";
            homeToolStripMenuItem1.Click += homeToolStripMenuItem1_Click;
            // 
            // settingsToolStripMenuItem1
            // 
            settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            settingsToolStripMenuItem1.Size = new Size(74, 24);
            settingsToolStripMenuItem1.Text = "Settings";
            settingsToolStripMenuItem1.Click += settingsToolStripMenuItem1_Click;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(75, 24);
            accountToolStripMenuItem.Text = "Account";
            accountToolStripMenuItem.Click += accountToolStripMenuItem_Click;
            // 
            // Home
            // 
            Home.Anchor = AnchorStyles.Top;
            Home.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Home.Location = new Point(17, 31);
            Home.Name = "Home";
            Home.Size = new Size(850, 500);
            Home.TabIndex = 2;
            // 
            // Settings
            // 
            Settings.Anchor = AnchorStyles.Top;
            Settings.Location = new Point(26, 31);
            Settings.Name = "Settings";
            Settings.Size = new Size(824, 511);
            Settings.TabIndex = 3;
            // 
            // account1
            // 
            Account.Anchor = AnchorStyles.Top;
            Account.Location = new Point(26, 31);
            Account.Name = "Account";
            Account.Size = new Size(824, 511);
            Account.TabIndex = 4;
            // 
            // FlightBookingSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 531);
            Controls.Add(Account);
            Controls.Add(Settings);
            Controls.Add(Home);
            Controls.Add(menuStrip2);
            Name = "FlightBookingSystem";
            Text = "Flight Booking System";
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip2;
        private ToolStripMenuItem homeToolStripMenuItem1;
        private ToolStripMenuItem settingsToolStripMenuItem1;
        private ToolStripMenuItem accountToolStripMenuItem;
        private PL_FlightBookingSystem.Home Home;
        private PL_FlightBookingSystem.Settings Settings;
        private Account Account;
    }
}