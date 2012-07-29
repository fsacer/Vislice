using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vislice
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
            var frm = new Prijava();
            frm.ControlBox = false;
            frm.ShowInTaskbar = false;
            Application.Run(frm);
            if (frm.LogonSuccessfull)
            {
                Application.Run(new Main());
            }
            if (frm.Relogin)
            {
                Application.Run(frm);
            }
        }
        public static void Reinit()
        {
            var frm = new Prijava();
            frm.ControlBox = false;
            frm.ShowInTaskbar = false;
            Application.Run(frm);
            if (frm.LogonSuccessfull)
            {
                Application.Run(new Main());
            }
            if (frm.Relogin)
            {
                Application.Run(frm);
            }
        }
    }
}
