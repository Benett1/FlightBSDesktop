using PL_FlightBookingSystem;
using System.Windows.Forms;

namespace FlightBookingSystem
{
    public partial class FlightBookingSystem : Form
    {
        public FlightBookingSystem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Home.BringToFront();
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GlobalState.GetInstance(sender.ToString()!).BringToFront();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GlobalState.GetInstance(sender.ToString()!).BringToFront();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalState.GetInstance(sender.ToString()!).BringToFront();
        }

        private void settings1_Load(object sender, EventArgs e)
        {

        }
    }
}