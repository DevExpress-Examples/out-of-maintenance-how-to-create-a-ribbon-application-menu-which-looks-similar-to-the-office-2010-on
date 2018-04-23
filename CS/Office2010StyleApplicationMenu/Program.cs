using System;
using System.Windows.Forms;
using DevExpress.UserSkins;

namespace Office2010StyleApplicationMenu
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
            OfficeSkins.Register();
            Application.Run(new Form1());
        }
    }
}
