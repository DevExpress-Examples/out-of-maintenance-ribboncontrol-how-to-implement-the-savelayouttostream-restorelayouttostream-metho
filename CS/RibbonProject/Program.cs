using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Skins;

namespace RibbonProject
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
            Application.SetCompatibleTextRenderingDefault(true);
            SkinManager.EnableFormSkins();
            Application.Run(new XtraForm1());
        }
    }
}
