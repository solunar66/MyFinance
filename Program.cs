using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyFinance
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createNew;
            using (System.Threading.Mutex m = new System.Threading.Mutex(true, Application.ProductName, out createNew))
            {
                if (createNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form_Main());
                }
                else
                {
                    //MessageBox.Show("Only one instance of this application is allowed!");
                }
            }
        }
    }
}
