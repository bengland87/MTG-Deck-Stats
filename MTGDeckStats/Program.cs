using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTGDeckStats
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            //load DLL
            var DLL = Assembly.LoadFile(@"C:\Users\Brian\Documents\Visual Studio 2015\Projects\MTGDeckStats\SQLite.Interop.dll");

            foreach (Type type in DLL.GetExportedTypes())
            {
                dynamic c = Activator.CreateInstance(type);
                c.Output(@"Hello");
            }
            */

            Console.ReadLine();
            //initialize DB
            DB database = new DB();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(database));
        }
    }
}
