using FBS.DAL;
using FlightBookingSystem.Models;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FBS.DAL;
using FBS.DAL_2.Authentication;
using FlightBookingSystem.Models;
using WindowsFormsApp1.CustomViews;

namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchFlightBtn = new System.Windows.Forms.Button();
            this.arrivalBox = new System.Windows.Forms.ComboBox();
            this.depatureBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.accInfo1 = new WindowsFormsApp1.CustomViews.AccInfo();
            this.account_SignUp1 = new PL_FlightBookingSystem.Account();
            this.label6 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1011, 725);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 719);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabPage1.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage1.Controls.Add(this.flowLayoutPanel);
            this.tabPage1.Controls.Add(this.searchFlightBtn);
            this.tabPage1.Controls.Add(this.arrivalBox);
            this.tabPage1.Controls.Add(this.depatureBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(997, 688);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(103, 109);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(800, 580);
            this.flowLayoutPanel.TabIndex = 7;
            this.flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_Paint);
            // 
            // searchFlightBtn
            // 
            this.searchFlightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchFlightBtn.Location = new System.Drawing.Point(714, 50);
            this.searchFlightBtn.Name = "searchFlightBtn";
            this.searchFlightBtn.Size = new System.Drawing.Size(156, 29);
            this.searchFlightBtn.TabIndex = 4;
            this.searchFlightBtn.Text = "Search Flight";
            this.searchFlightBtn.UseVisualStyleBackColor = true;
            this.searchFlightBtn.Click += new System.EventHandler(this.searchFlightBtn_Click);
            // 
            // arrivalBox
            // 
            this.arrivalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.arrivalBox.FormattingEnabled = true;
            this.arrivalBox.Items.AddRange(new object[] {
            "Shkup",
            "Prishtine"});
            this.arrivalBox.Location = new System.Drawing.Point(532, 50);
            this.arrivalBox.Name = "arrivalBox";
            this.arrivalBox.Size = new System.Drawing.Size(153, 28);
            this.arrivalBox.TabIndex = 3;
            // 
            // depatureBox
            // 
            this.depatureBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.depatureBox.FormattingEnabled = true;
            this.depatureBox.Items.AddRange(new object[] {
            "Prishtine",
            "Shkup"});
            this.depatureBox.Location = new System.Drawing.Point(243, 50);
            this.depatureBox.Name = "depatureBox";
            this.depatureBox.Size = new System.Drawing.Size(153, 28);
            this.depatureBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(423, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Arrival Airport";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(105, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departure Airport";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 688);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bookings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bookings";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage3.Controls.Add(this.accInfo1);
            this.tabPage3.Controls.Add(this.account_SignUp1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(997, 688);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Account";
            // 
            // accInfo1
            // 
            this.accInfo1.BackColor = System.Drawing.Color.CadetBlue;
            this.accInfo1.Location = new System.Drawing.Point(25, 74);
            this.accInfo1.Name = "accInfo1";
            this.accInfo1.Size = new System.Drawing.Size(698, 362);
            this.accInfo1.TabIndex = 17;
            this.accInfo1.Visible = false;
            this.accInfo1.Hide();
            GlobalState.setInstance(this.accInfo1);
            // 
            // account_SignUp1
            // 
            this.account_SignUp1.BackColor = System.Drawing.Color.CadetBlue;
            this.account_SignUp1.Location = new System.Drawing.Point(8, 74);
            this.account_SignUp1.Name = "account_SignUp1";
            this.account_SignUp1.Size = new System.Drawing.Size(945, 362);
            this.account_SignUp1.TabIndex = 16;
            GlobalState.setInstance(account_SignUp1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "Account";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1011, 725);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Flight Booking System";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button searchFlightBtn;
        private ComboBox arrivalBox;
        private ComboBox depatureBox;
        private Label label3;
        private Label label1;
        private TabPage tabPage2;
        private Label label2;
        private TabPage tabPage3;
        private Label label6;
        private BindingSource bindingSource1;
        private PL_FlightBookingSystem.Account account_SignUp1;
        private CustomViews.AccInfo accInfo1;
        private FlowLayoutPanel flowLayoutPanel;
    }
}

