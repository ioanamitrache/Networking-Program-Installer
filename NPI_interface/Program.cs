using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPI_interface
{
    using Classes;
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
            ManagedManager manager = (ManagedManager)ManagedManager.GetInstance();
            Application.Run(new FormMain());
        }
    }
}
