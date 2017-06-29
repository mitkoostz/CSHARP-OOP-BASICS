using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Globalization;
using System.Text;

namespace MyCalories
{
    static class StartUp
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            loadFoods lf = new loadFoods();
            lf.readFoods();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
           
                
        }
    }
}
