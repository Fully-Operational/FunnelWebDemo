using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunnelWebDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!FunnelWebDemo.Classes.WBEmulator.IsBrowserEmulationSet())
            {
                FunnelWebDemo.Classes.WBEmulator.SetBrowserEmulationVersion();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new frmMain2());
        }
    }
}
