using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace LAN_Checker
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new MainFrm());
            }
            catch (System.BadImageFormatException)
            {
                MessageBox.Show("DEVELOPER ERROR: Please change DLL compiling settings to Any CPU", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
