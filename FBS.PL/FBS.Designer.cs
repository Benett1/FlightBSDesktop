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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flightsTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchFlightBtn = new System.Windows.Forms.Button();
            this.arrivalBox = new System.Windows.Forms.ComboBox();
            this.depatureBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookingPage = new System.Windows.Forms.TabPage();
            this.flowLayoutBookingsPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TtitleLbl = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.signup1 = new WindowsFormsApp1.CustomViews.Signup();
            this.account1 = new PL_FlightBookingSystem.Account();
            this.accInfo1 = new WindowsFormsApp1.CustomViews.AccInfo();
            this.label6 = new System.Windows.Forms.Label();
            this.account_SignUp1 = new PL_FlightBookingSystem.Account();
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flightsTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.bookingPage.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.flightsTab, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // flightsTab
            // 
            this.flightsTab.Controls.Add(this.tabPage1);
            this.flightsTab.Controls.Add(this.bookingPage);
            this.flightsTab.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.flightsTab, "flightsTab");
            this.flightsTab.Multiline = true;
            this.flightsTab.Name = "flightsTab";
            this.flightsTab.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage1.Controls.Add(this.flowLayoutPanel);
            this.tabPage1.Controls.Add(this.searchFlightBtn);
            this.tabPage1.Controls.Add(this.arrivalBox);
            this.tabPage1.Controls.Add(this.depatureBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Name = "tabPage1";
            // 
            // flowLayoutPanel
            // 
            resources.ApplyResources(this.flowLayoutPanel, "flowLayoutPanel");
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_Paint);
            // 
            // searchFlightBtn
            // 
            resources.ApplyResources(this.searchFlightBtn, "searchFlightBtn");
            this.searchFlightBtn.Name = "searchFlightBtn";
            this.searchFlightBtn.UseVisualStyleBackColor = true;
            this.searchFlightBtn.Click += new System.EventHandler(this.searchFlightBtn_Click);
            // 
            // arrivalBox
            // 
            resources.ApplyResources(this.arrivalBox, "arrivalBox");
            this.arrivalBox.FormattingEnabled = true;
            this.arrivalBox.Name = "arrivalBox";
            // 
            // depatureBox
            // 
            resources.ApplyResources(this.depatureBox, "depatureBox");
            this.depatureBox.FormattingEnabled = true;
            this.depatureBox.Name = "depatureBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // bookingPage
            // 
            this.bookingPage.BackColor = System.Drawing.Color.CadetBlue;
            this.bookingPage.Controls.Add(this.flowLayoutBookingsPanel1);
            this.bookingPage.Controls.Add(this.TtitleLbl);
            resources.ApplyResources(this.bookingPage, "bookingPage");
            this.bookingPage.Name = "bookingPage";
            this.bookingPage.Click += new System.EventHandler(this.bookingPage_Click);
            // 
            // flowLayoutBookingsPanel1
            // 
            resources.ApplyResources(this.flowLayoutBookingsPanel1, "flowLayoutBookingsPanel1");
            this.flowLayoutBookingsPanel1.Name = "flowLayoutBookingsPanel1";
            this.flowLayoutBookingsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutBookingsPanel1_Paint);
            // 
            // TtitleLbl
            // 
            resources.ApplyResources(this.TtitleLbl, "TtitleLbl");
            this.TtitleLbl.Name = "TtitleLbl";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage3.Controls.Add(this.signup1);
            this.tabPage3.Controls.Add(this.account1);
            this.tabPage3.Controls.Add(this.accInfo1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.account_SignUp1);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            // 
            // signup1
            // 
            this.signup1.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.signup1, "signup1");
            this.signup1.Name = "signup1";
            // 
            // account1
            // 
            this.account1.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.account1, "account1");
            this.account1.Name = "account1";
            this.account1.Load += new System.EventHandler(this.account1_Load);
            // 
            // accInfo1
            // 
            this.accInfo1.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.accInfo1, "accInfo1");
            this.accInfo1.Name = "accInfo1";
            this.accInfo1.Load += new System.EventHandler(this.accInfo1_Load);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // account_SignUp1
            // 
            this.account_SignUp1.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.account_SignUp1, "account_SignUp1");
            this.account_SignUp1.Name = "account_SignUp1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Name = "label9";
            // 
            // planesDrop
            // 
            resources.ApplyResources(this.planesDrop, "planesDrop");
            this.planesDrop.FormattingEnabled = true;
            this.planesDrop.Name = "planesDrop";
            // 
            // departureDrop
            // 
            resources.ApplyResources(this.departureDrop, "departureDrop");
            this.departureDrop.FormattingEnabled = true;
            this.departureDrop.Name = "departureDrop";
            // 
            // arrivalDrop
            // 
            resources.ApplyResources(this.arrivalDrop, "arrivalDrop");
            this.arrivalDrop.FormattingEnabled = true;
            this.arrivalDrop.Name = "arrivalDrop";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // submit
            // 
            resources.ApplyResources(this.submit, "submit");
            this.submit.Name = "submit";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flightsTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.bookingPage.ResumeLayout(false);
            this.bookingPage.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);


            GlobalState.setInstance(signup1);
            GlobalState.setInstance(account1);
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
        private TabPage bookingPage;
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
        private FlowLayoutPanel flowLayoutBookingsPanel1;
    }
}

