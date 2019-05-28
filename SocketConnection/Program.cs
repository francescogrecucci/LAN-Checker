using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SocketConnection
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new SocketConnectionForm());
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "LAN Checker", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
