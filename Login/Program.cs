using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    /// <summary>
    /// 
    /// </summary>
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
           // Application.Run(new frmLogin());
            //Application.Run(new frmInicio());
<<<<<<< HEAD
            Application.Run(new frmPacientes());
=======
            Application.Run(new frmPrincipal());
>>>>>>> parent of 6f39286... Felipe Avelino
        }
    }
}
