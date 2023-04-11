using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_FlightBookingSystem
{
    internal static class GlobalState
    {
        public static int Logged { get; set; } 
        public static List<UserControl> StateInstances = new List<UserControl>();

        public static UserControl GetInstance(string name)
        {
            return StateInstances.First(e => e.Name == name);
        }

        public static void setInstance(UserControl userControl) {
            StateInstances.Add(userControl);
        }
    }
}
