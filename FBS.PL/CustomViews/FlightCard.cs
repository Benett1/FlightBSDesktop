﻿using FlightBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.CustomViews
{
    public partial class FlightCard : UserControl
    {
        private FlightModel model;

        public FlightCard(FlightModel model)
        {
            InitializeComponent();
            this.model = model;
        }

        private void FlightCard_Load(object sender, EventArgs e)
        {
            flightLbl.Text = model.Id.ToString();
            departurelLbl.Text = model.DepartureAirport.ToString();
            arrivalLbl.Text = model.ArrivalAirport.ToString();
            dateTimeLbl.Text = model.DateTime.ToString();
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            if (GlobalState.user != null)
            {
                BookingPannel b1 = new BookingPannel(model);

                Form form = new Form();
                form.Height = 366;
                form.Width = 319;
                form.Show();
                form.Controls.Add(b1);
            }
            else {
                GlobalState.getTab("flightsTab").SelectedIndex = 2;
            }
        }
    }
}
