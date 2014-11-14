﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmingprogram
{
    //CREATED BY: SP1062 pls add SID
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
        }

        private static LogIn staff;

        public static void setStaff(LogIn s)
        {
            staff = s;
        }

        public static LogIn getStaff()
        {
            return staff;
        }
    }
}
