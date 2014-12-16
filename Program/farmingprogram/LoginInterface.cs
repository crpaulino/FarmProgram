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
    public partial class LoginInterface : Form
    {
        public LoginInterface()
        {
            Thread timeoutThread = new Thread(new ThreadStart(SplashScreen.startSplashScreen)); //Thread which displays splash screen
            timeoutThread.Start(); //Start thread
            Thread.Sleep(SplashScreen.SPLASH_SCREEN_TIMEOUT); //Thread will be delayed by SPLASH_SCREEN_TIMEOUT milliseconds
            CenterToScreen(); //Place the form in the center
            InitializeComponent();
            timeoutThread.Abort(); //Close thread
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBox_Click(object sender, EventArgs e)
        {
            String name = usernameBox.Text; //Username from text box
            String password = passwordBox.Text; //Password from text box
            if (SqlConnector.validPassword(name, password)) //If valid password
            {
                this.Close(); //Close sql connection
            }
        }
    }
}
