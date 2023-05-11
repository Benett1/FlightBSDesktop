using FlightBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FBS.DAL;
using FBS.DAL.Locations;
using FBS.DAL.Aeroports;

namespace WindowsFormsApp1.CustomViews
{
    internal static class GlobalState
    {
        public static bool Logged { get; set; }
        public static bool Painted { get; set; } = false;
        public static bool bookingPainted { get; set; } = false;
        public static UserModel user { get; set; }

        public static List<UserControl> StateInstances = new List<UserControl>();
        public static List<TabControl> tabControls = new List<TabControl>();
        public static List<LocationModel> Locations = new List<LocationModel>( new DAOLocatinos().AllLocations());
        public static List<AirportModel> Airports = new List<AirportModel>( new DAOAiroports().GetAeroports());
        public static TabPage tabPage = new TabPage();
        public static FlowLayoutPanel BookingLayout { get; set; }
        public static FlowLayoutPanel HomeLayout { get; set; }

        public static void setTabFlights(TabPage tab)
        {
            tabPage = tab;
        }

        public static TabPage getTabFlights()
        {
            return tabPage;
        }

        public static void setTab(TabControl tab){
            tabControls.Add(tab);
        }

        public static TabControl getTab(String tab)
        {
            return tabControls.First(e => e.Name == tab);
        }

        public static UserControl GetInstance(string name)
        {
            return StateInstances.First(e => e.Name == name);
        }

        public static void setInstance(UserControl userControl)
        {
            StateInstances.Add(userControl);
        }
    }
}
