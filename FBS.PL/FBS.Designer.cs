using System.Windows.Forms;
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
            this.flightsTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchFlightBtn = new System.Windows.Forms.Button();
            this.arrivalBox = new System.Windows.Forms.ComboBox();
            this.depatureBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TtitleLbl = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.account1 = new PL_FlightBookingSystem.Account();
            this.accInfo1 = new WindowsFormsApp1.CustomViews.AccInfo();
            this.label6 = new System.Windows.Forms.Label();
            this.account_SignUp1 = new PL_FlightBookingSystem.Account();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.planesDrop = new System.Windows.Forms.ComboBox();
            this.departureDrop = new System.Windows.Forms.ComboBox();
            this.arrivalDrop = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.submit = new System.Windows.Forms.Button();
            this.signup1 = new WindowsFormsApp1.CustomViews.Signup();
            this.tableLayoutPanel1.SuspendLayout();
            this.flightsTab.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.flightsTab, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1011, 725);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flightsTab
            // 
            this.flightsTab.Controls.Add(this.tabPage1);
            this.flightsTab.Controls.Add(this.tabPage2);
            this.flightsTab.Controls.Add(this.tabPage3);
            this.flightsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flightsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.flightsTab.Location = new System.Drawing.Point(3, 3);
            this.flightsTab.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.flightsTab.Multiline = true;
            this.flightsTab.Name = "flightsTab";
            this.flightsTab.SelectedIndex = 0;
            this.flightsTab.Size = new System.Drawing.Size(1005, 719);
            this.flightsTab.TabIndex = 1;
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
            this.arrivalBox.Location = new System.Drawing.Point(532, 50);
            this.arrivalBox.Name = "arrivalBox";
            this.arrivalBox.Size = new System.Drawing.Size(153, 28);
            this.arrivalBox.TabIndex = 3;
            // 
            // depatureBox
            // 
            this.depatureBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.depatureBox.FormattingEnabled = true;
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
            this.tabPage2.Controls.Add(this.TtitleLbl);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 688);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bookings";
            // 
            // TtitleLbl
            // 
            this.TtitleLbl.AutoSize = true;
            this.TtitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TtitleLbl.Location = new System.Drawing.Point(427, 22);
            this.TtitleLbl.Name = "TtitleLbl";
            this.TtitleLbl.Size = new System.Drawing.Size(135, 33);
            this.TtitleLbl.TabIndex = 0;
            this.TtitleLbl.Text = "Bookings";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage3.Controls.Add(this.signup1);
            this.tabPage3.Controls.Add(this.account1);
            this.tabPage3.Controls.Add(this.accInfo1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.account_SignUp1);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(997, 688);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Account";
            // 
            // account1
            // 
            this.account1.BackColor = System.Drawing.Color.CadetBlue;
            this.account1.Location = new System.Drawing.Point(8, 73);
            this.account1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.account1.Name = "account1";
            this.account1.Size = new System.Drawing.Size(698, 361);
            this.account1.TabIndex = 18;
            this.account1.Load += new System.EventHandler(this.account1_Load);
            // 
            // accInfo1
            // 
            this.accInfo1.BackColor = System.Drawing.Color.CadetBlue;
            this.accInfo1.Location = new System.Drawing.Point(26, 73);
            this.accInfo1.Name = "accInfo1";
            this.accInfo1.Size = new System.Drawing.Size(698, 361);
            this.accInfo1.TabIndex = 17;
            this.accInfo1.Visible = false;
            this.accInfo1.Load += new System.EventHandler(this.accInfo1_Load);
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
            // account_SignUp1
            // 
            this.account_SignUp1.BackColor = System.Drawing.Color.CadetBlue;
            this.account_SignUp1.Location = new System.Drawing.Point(8, 73);
            this.account_SignUp1.Name = "account_SignUp1";
            this.account_SignUp1.Size = new System.Drawing.Size(945, 361);
            this.account_SignUp1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(295, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Plane";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(383, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 33);
            this.label5.TabIndex = 31;
            this.label5.Text = "Flights";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(295, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Date Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(295, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Departure Airport";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(295, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Arrival Airport";
            // 
            // planesDrop
            // 
            this.planesDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planesDrop.FormattingEnabled = true;
            this.planesDrop.Location = new System.Drawing.Point(454, 89);
            this.planesDrop.Name = "planesDrop";
            this.planesDrop.Size = new System.Drawing.Size(121, 28);
            this.planesDrop.TabIndex = 36;
            // 
            // departureDrop
            // 
            this.departureDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureDrop.FormattingEnabled = true;
            this.departureDrop.Location = new System.Drawing.Point(454, 126);
            this.departureDrop.Name = "departureDrop";
            this.departureDrop.Size = new System.Drawing.Size(121, 28);
            this.departureDrop.TabIndex = 37;
            // 
            // arrivalDrop
            // 
            this.arrivalDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalDrop.FormattingEnabled = true;
            this.arrivalDrop.Location = new System.Drawing.Point(454, 163);
            this.arrivalDrop.Name = "arrivalDrop";
            this.arrivalDrop.Size = new System.Drawing.Size(121, 28);
            this.arrivalDrop.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(454, 202);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(403, 257);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(151, 32);
            this.submit.TabIndex = 39;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // signup1
            // 
            this.signup1.BackColor = System.Drawing.Color.CadetBlue;
            this.signup1.Location = new System.Drawing.Point(8, 73);
            this.signup1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signup1.Name = "signup1";
            this.signup1.Size = new System.Drawing.Size(698, 362);
            this.signup1.TabIndex = 19;
            this.signup1.Hide();
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
            this.flightsTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            GlobalState.setInstance(signup1 );
            GlobalState.setInstance(account1 );
            GlobalState.setTab(flightsTab);
            GlobalState.setInstance(accInfo1);
            GlobalState.setInstance(account_SignUp1);
            GlobalState.setInstance(account_SignUp1);

        }

        //GlobalState.setInstance(signup1 );
        //    GlobalState.setInstance(account1 );
        //    GlobalState.setTab(flightsTab);
        //    GlobalState.setInstance(accInfo1);
        //    GlobalState.setInstance(account_SignUp1);
        //    GlobalState.setInstance(account_SignUp1);

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private BindingSource bindingSource1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private ComboBox arrivalDrop;
        private ComboBox departureDrop;
        private ComboBox planesDrop;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Button submit;
        private TabControl flightsTab;
        private TabPage tabPage1;
        private FlowLayoutPanel flowLayoutPanel;
        private Button searchFlightBtn;
        public ComboBox arrivalBox;
        public ComboBox depatureBox;
        private Label label3;
        private Label label1;
        private TabPage tabPage2;
        private Label TtitleLbl;
        private TabPage tabPage3;
        private AccInfo accInfo1;
        private PL_FlightBookingSystem.Account account_SignUp1;
        private Label label6;
        private TabPage tabPage4;
        private DateTimePicker dateTimePicker2;
        private ComboBox AArrivalBox;
        private ComboBox DepartureBox;
        private ComboBox FlightBox;
        
        private Button SSubmit;
        private Label DdateLbl;
        private PL_FlightBookingSystem.Account account1;
        private Signup signup1;
    }
}

