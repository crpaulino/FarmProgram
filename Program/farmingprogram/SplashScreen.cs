using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace farmingprogram
{
    //Created by 1333187
    public partial class SplashScreen : Form
    {        
        public const int SPLASH_SCREEN_TIMEOUT = 5000; //This form will only display for 5 seconds
        public static SplashScreen splash; //Instance of SplashScreen

        public SplashScreen()
        {
            CenterToScreen(); //Center splash screen
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            Console.WriteLine();
        }


        //Starts the splash screen
        public static void startSplashScreen()
        {
            splash = new SplashScreen(); //Instance is set
            Application.Run(splash); //Application will display the screen
        }
    }
}
