using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coffee_Restaurent_Manager.Forms;

namespace Coffee_Restaurent_Manager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
                [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Coffee_Restaurent_Manager.Forms.LoginForm loginForm = new LoginForm();

            Application.Run(loginForm);

            if(loginForm.IsLoggedIn)
            {
                Application.Run(new MainForm());
            }

        }

        
    }
}
