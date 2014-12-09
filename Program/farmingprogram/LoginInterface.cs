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
            Thread timeoutThread = new Thread(new ThreadStart(SplashScreen.startSplashScreen));
            timeoutThread.Start();
            Thread.Sleep(SplashScreen.SPLASH_SCREEN_TIMEOUT);
            CenterToScreen();
            InitializeComponent();
            timeoutThread.Abort();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBox_Click(object sender, EventArgs e)
        {
            String name = usernameBox.Text;
            String password = passwordBox.Text;
            if (SqlConnector.validPassword(name, password))
            {
                this.Close();
            }
        }

      
        //1307211 & 1312754
        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loginBox_Click(this, new EventArgs());
        }
    }
}
