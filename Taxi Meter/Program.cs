using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi_Meter
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
            mainframe main = new mainframe();
            Application.Run(main);
            //Application.Run(new mainframe());
            if (!string.IsNullOrEmpty(main.log))
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Dropbox\Dev\Stuffs\Taxi Meter\Log.txt", true))
                {
                    file.WriteLine(main.log + "**********\n");
                }
            }
        }
    }

}
