using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using tetris3Dv1.App_Views;

namespace tetris3Dv1
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
            //Application.Run(new ViewTetris());
            Application.Run(new ViewConfiguraciones());
        }
    }
}
