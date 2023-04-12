using FlightBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.CustomViews
{
    internal static class GlobalState
    {
        public static bool Logged { get; set; }
        public static bool Painted { get; set; } = false;
        public static UserModel user { get; set; }

        public static List<UserControl> StateInstances = new List<UserControl>();

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
