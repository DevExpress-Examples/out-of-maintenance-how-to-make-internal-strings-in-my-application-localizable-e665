using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyApp {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            if(args.Length > 0 && (args[0] == "en" || args[0] == "fr"))
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(args[0]);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}