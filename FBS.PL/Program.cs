using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (MessageBox.Show("Press Yes for Albanian  or  No for English", "Language", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Thread.CurrentThread.CurrentCulture = new CultureInfo("sq-XK");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("sq-XK");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
