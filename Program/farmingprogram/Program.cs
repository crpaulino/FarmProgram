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
            Application.Run(new LoginInterface());
            Application.Run(new MainProgram());
        }

        private static LoginDetail staff;

        public static void setStaff(LoginDetail s)
        {
            staff = s;
        }

        public static LoginDetail getStaff()
        {
            return staff;
        }
    }
}
