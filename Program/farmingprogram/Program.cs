using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmingprogram
{
    //Made by 1333187
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

            SqlConnector.startConnection();
            if (!Constants.TESTING_MODE) //If not testing then prompt login
            {
                Application.Run(new LoginInterface()); //Prompts login
            }
            else //If testing
            {
                loginDetail = new LoginDetail("admin", "admin", 1); //Default user and password = admin, admin
                SqlConnector.getConnection().Close(); //Close connection left open for login
            }
            if (loginDetail != null) //If login detail is not null then run the program
            {
                Application.Run(new MainProgram()); //Run main program
            }
        }

        private static LoginDetail loginDetail; //Login detail field

        public static void setLogin(LoginDetail ld) //Login detail setter
        {
            loginDetail = ld;
        }

        public static LoginDetail getLoginDetail() //Login detail getter
        {
            return loginDetail;
        }
    }
}
