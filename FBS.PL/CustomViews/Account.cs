using FBS.DAL_2.Authentication;
using FBS.DAL;
using System;
using System.Windows.Forms;
using WindowsFormsApp1.CustomViews;
using FlightBookingSystem.Models;
using System.Collections.Generic;
using FBS.DAL.Locations;

namespace PL_FlightBookingSystem
{
    public partial class Account : UserControl
    {
        private DAOAuthentication daoAuthentication { get; set; }
        private DAOFlights daoFlights { get; set; }
       
        public Account()
        {
            InitializeComponent();
            daoAuthentication = new DAOAuthentication();
            daoFlights = new DAOFlights();
        }


        private void UpdateFlight_Click(object sender, EventArgs e) {
            FlightModel model = new FlightModel();
            try
            {
                model.DateTime = dateTimePicker2.Value;
                model.PlaneId = Guid.Parse(PPlaneBox.Text);
                Guid dep = GlobalState.Locations.Find(x => x.City == DepartureBox.Text).Id;
                Guid arr = GlobalState.Locations.Find(x => x.City == AArrivalBox.Text).Id;
                Guid depId = GlobalState.Airports.Find(el => el.LocationID == dep).Id;
                Guid arrId = GlobalState.Airports.Find(el => el.LocationID == arr).Id;
                if (FlightBox.Text.Equals("New"))
                {
                    MessageBox.Show("Flight Id cant be changed");
                }
                else
                {
                    model.Id = Guid.Parse(FlightBox.Text.ToString());
                    daoFlights.UpdateFlight(model, depId, arrId);
                    updateDropFlights();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill the data");
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Perform whatever action you want to take when the user clicks the Submit button

            // Hide the pop-up panel
            popupPanel.Visible = false;
        }

        private void RegisterFlight_Click(object sender, EventArgs e) {
            FlightModel model = new FlightModel();
            try
            {
                model.DateTime = dateTimePicker2.Value;
                model.PlaneId = Guid.Parse(PPlaneBox.Text);
                Guid dep = GlobalState.Locations.Find(x => x.City == DepartureBox.Text).Id;
                Guid arr = GlobalState.Locations.Find(x => x.City == AArrivalBox.Text).Id;
                Guid depId = GlobalState.Airports.Find(el => el.LocationID == dep).Id;
                Guid arrId = GlobalState.Airports.Find(el => el.LocationID == arr).Id;
                if (!FlightBox.Text.Equals("New"))
                {
                    MessageBox.Show("Two flights cant have the same id");
                }
                else
                {
                    model.Id = Guid.NewGuid();
                    daoFlights.AddFlight(model, depId,arrId);
                }
            }
            catch(Exception ex) {
                MessageBox.Show("Fill the data");
            }
        }

        private void DeleteFLightsById(object sender, EventArgs e)
        {
            Form dialogBox = new Form();
            dialogBox.Height = 200;
            dialogBox.Width = 250;
            dialogBox.FormBorderStyle = FormBorderStyle.FixedDialog;

            dialogBox.Text = "Select an option";

            Label label = new Label();
            label.Location = new System.Drawing.Point(70, 00);
            label.Text = "Select one Flight";

            // Create a ComboBox control and add items to it
            ComboBox comboBox = new ComboBox();
            comboBox.Location = new System.Drawing.Point(20, 30);
            comboBox.Width = 200;
            comboBox.Items.AddRange(new DAOFlights().GetFlightsByRole(GlobalState.user.RoleId).ToArray());
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // Create a button to close the dialog box
            Label label2 = new Label();
            label2.Text = "Do you want to delete this";

            Button button = new Button();
            button.Text = "OK";
            button.DialogResult = DialogResult.OK;
            button.Dock = DockStyle.Bottom;


            // Add the ComboBox and button controls to the dialog box
            dialogBox.Controls.Add(label);
            dialogBox.Controls.Add(comboBox);
            dialogBox.Controls.Add(button);
            
            

            // Show the dialog box and wait for the user to make a selection
            if (dialogBox.ShowDialog() == DialogResult.OK)
            {
                string selectedItem = comboBox.SelectedItem.ToString();
                DialogResult result = MessageBox.Show($"You selected: {selectedItem}",  "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes )
                {
                    daoFlights.DeleteFlight(Guid.Parse(selectedItem));
                }
            }

        }


        private Label DDepartureLbl;
        private Label FflightLbl;
        private Button SSubmit;
        private Button UUpdate;
        private Button DeleteBtn;
        private Label DdateLbl;
        private Label PplaneLabel;
        private ComboBox PPlaneBox;
        private DateTimePicker dateTimePicker2;
        private ComboBox AArrivalBox;
        private ComboBox DepartureBox;
        private ComboBox FlightBox;
        private Label AarrivalLbl;
        private Label TtitleLbl;
        private Panel popupPanel;

        private void Login_Click(object sender, EventArgs e)
        {
            var res = daoAuthentication.Login(LogUsernameTxt.Text, LogPasswordTxt.Text);
            if (res != null) {

                GlobalState.GetInstance("account1").Hide();
                MessageBox.Show("Logged In");
                LogUsernameTxt.Text = ""; LogPasswordTxt.Text = "";
                GlobalState.Logged = true;
                GlobalState.user = res;
                GlobalState.GetInstance("accInfo1").Show();
                GlobalState.GetInstance("account_SignUp1").Hide();
                GlobalState.GetInstance("accInfo1").Refresh();

                if (res.RoleId == 2) {
                    TabPage tabPage4 = new TabPage("Flights");
                    tabPage4.BackColor = System.Drawing.Color.CadetBlue;

                    TtitleLbl = new Label();
                    DDepartureLbl = new Label();
                    FflightLbl = new Label();
                    AarrivalLbl = new Label();
                    FlightBox = new ComboBox();
                    DepartureBox = new ComboBox();
                    AArrivalBox = new ComboBox();
                    dateTimePicker2 = new DateTimePicker();
                    SSubmit = new Button();
                    DdateLbl = new Label();
                    PplaneLabel = new Label();
                    PPlaneBox = new ComboBox();
                    UUpdate = new Button();
                    DeleteBtn = new Button();
                    popupPanel = new Panel();

                    // 
                    // TtitleLbl
                    // 
                    TtitleLbl.AutoSize = true;
                    TtitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    TtitleLbl.Location = new System.Drawing.Point(427, 22);
                    TtitleLbl.Name = "TtitleLbl";
                    TtitleLbl.Size = new System.Drawing.Size(135, 33);
                    TtitleLbl.TabIndex = 0;
                    TtitleLbl.Text = "Flights";

                    // 
                    // FflightLbl
                    // 
                    FflightLbl.AutoSize = true;
                    FflightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                    FflightLbl.Location = new System.Drawing.Point(368, 104);
                    FflightLbl.Name = "FflightLbl";
                    FflightLbl.Size = new System.Drawing.Size(66, 20);
                    FflightLbl.TabIndex = 36;
                    FflightLbl.Text = "Flight Id";
                    // 
                    // FlightBox
                    // 
                    FlightBox.FormattingEnabled = true;
                    FlightBox.Location = new System.Drawing.Point(466, 102);
                    FlightBox.Name = "FlightBox";
                    FlightBox.Size = new System.Drawing.Size(161, 26);
                    FlightBox.TabIndex = 46;

                    // 
                    // PlaneLbl
                    // 
                    PplaneLabel.AutoSize = true;
                    PplaneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                    PplaneLabel.Location = new System.Drawing.Point(368, 140);
                    PplaneLabel.Name = "AarrivalLbl";
                    PplaneLabel.Size = new System.Drawing.Size(52, 20);
                    PplaneLabel.TabIndex = 45;
                    PplaneLabel.Text = "Plane";

                    // 
                    // PlaneBox
                    // 
                    PPlaneBox.FormattingEnabled = true;
                    PPlaneBox.Location = new System.Drawing.Point(466, 143);
                    PPlaneBox.Name = "DepartureBox";
                    PPlaneBox.Size = new System.Drawing.Size(161, 26);
                    PPlaneBox.TabIndex = 47;

                    // 
                    // DDepartureLbl
                    // 
                    DDepartureLbl.AutoSize = true;
                    DDepartureLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                    DDepartureLbl.Location = new System.Drawing.Point(368, 176);
                    DDepartureLbl.Name = "DDepartureLbl";
                    DDepartureLbl.Size = new System.Drawing.Size(81, 20);
                    DDepartureLbl.TabIndex = 37;
                    DDepartureLbl.Text = "Departure";
                    // 
                    // DepartureBox
                    // 
                    DepartureBox.FormattingEnabled = true;
                    DepartureBox.Location = new System.Drawing.Point(466, 179);
                    DepartureBox.Name = "DepartureBox";
                    DepartureBox.Size = new System.Drawing.Size(161, 26);
                    DepartureBox.TabIndex = 47;

                    // 
                    // AarrivalLbl
                    // 
                    AarrivalLbl.AutoSize = true;
                    AarrivalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                    AarrivalLbl.Location = new System.Drawing.Point(368, 212);
                    AarrivalLbl.Name = "AarrivalLbl";
                    AarrivalLbl.Size = new System.Drawing.Size(52, 20);
                    AarrivalLbl.TabIndex = 45;
                    AarrivalLbl.Text = "Arrival";

                    // 
                    // AArrivalBox
                    // 
                    AArrivalBox.FormattingEnabled = true;
                    AArrivalBox.Location = new System.Drawing.Point(466, 215);
                    AArrivalBox.Name = "AArrivalBox";
                    AArrivalBox.Size = new System.Drawing.Size(161, 26);
                    AArrivalBox.TabIndex = 48;


                    // 
                    // DdateLbl
                    // 
                    DdateLbl.AutoSize = true;
                    DdateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                    DdateLbl.Location = new System.Drawing.Point(368, 248);
                    DdateLbl.Name = "DdateLbl";
                    DdateLbl.Size = new System.Drawing.Size(82, 20);
                    DdateLbl.TabIndex = 38;
                    DdateLbl.Text = "Date Time";

                    // 
                    // dateTimePicker2
                    // 
                    dateTimePicker2.Location = new System.Drawing.Point(466, 251);
                    dateTimePicker2.Name = "dateTimePicker2";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "MM/dd/yyyy hh:mm"; // Use the desired date/time format


                    // 
                    // SSubmit
                    // 

                    SSubmit.Location = new System.Drawing.Point(323, 300);
                    SSubmit.Name = "Register";
                    SSubmit.Size = new System.Drawing.Size(151, 32);
                    SSubmit.TabIndex = 40;
                    SSubmit.Text = "Register";
                    SSubmit.UseVisualStyleBackColor = true;
                    SSubmit.Click += new System.EventHandler(this.RegisterFlight_Click);

                    // 
                    // Uupdate
                    // 

                    UUpdate.Location = new System.Drawing.Point(483, 300);
                    UUpdate.Name = "update";
                    UUpdate.Size = new System.Drawing.Size(151, 32);
                    UUpdate.TabIndex = 40;
                    UUpdate.Text = "Update";
                    UUpdate.UseVisualStyleBackColor = true;
                    UUpdate.Click += new System.EventHandler(this.UpdateFlight_Click);

                    //
                    // Delete Btn
                    //

                    DeleteBtn.Location = new System.Drawing.Point(410, 350);
                    DeleteBtn.Name = "Delete";
                    DeleteBtn.ForeColor = System.Drawing.Color.Red;
                    DeleteBtn.Size = new System.Drawing.Size(151, 32);
                    DeleteBtn.TabIndex = 40;
                    DeleteBtn.Text = "Delete";
                    DeleteBtn.UseVisualStyleBackColor = true;
                    DeleteBtn.Click += new System.EventHandler(this.DeleteFLightsById);

                    



                    tabPage4.Controls.Add(DDepartureLbl);
                    tabPage4.Controls.Add(DepartureBox);
                    tabPage4.Controls.Add(FflightLbl);
                    tabPage4.Controls.Add(AarrivalLbl);
                    tabPage4.Controls.Add(FlightBox);
                    tabPage4.Controls.Add(AArrivalBox);
                    tabPage4.Controls.Add(dateTimePicker2);
                    tabPage4.Controls.Add(DdateLbl);
                    tabPage4.Controls.Add(SSubmit);
                    tabPage4.Controls.Add(TtitleLbl);
                    tabPage4.Controls.Add(PplaneLabel);
                    tabPage4.Controls.Add(PPlaneBox);
                    tabPage4.Controls.Add(UUpdate);
                    tabPage4.Controls.Add(DeleteBtn);

                   

                    List<String> list = new List<String>();

                    foreach (var el in GlobalState.Locations) {
                        list.Add(el.City);
                    }

                    DepartureBox.Items.AddRange(list.ToArray());
                    AArrivalBox.Items.AddRange(list.ToArray());

                    PPlaneBox.Items.AddRange(daoFlights.GetFlightsId(GlobalState.user.RoleId).ToArray());

                    updateDropFlights();

                    //"flightsTab"
                    GlobalState.getTab("flightsTab").Controls.Add(tabPage4);
                    GlobalState.setTabFlights(tabPage4);
                }

            } else {
                MessageBox.Show("Problem while Loggin in");
        }


        }

        private void updateDropFlights()
        {
            FlightBox.Items.Clear();

            FlightBox.Items.AddRange(new object[] {
                    "New",
                    });

            FlightBox.Items.AddRange(new DAOFlights().GetFlightsByRole(GlobalState.user.RoleId).ToArray());
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            GlobalState.GetInstance("signup1").Show();
        }
    }
}
