using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Configuration;

namespace farmingprogram
{
    //Made by 1333187
    class SqlConnector
    {
        private static SqlConnection connection = null; //SqlConnection which is used throughout program

        //Start the sql connnection
        public static void startConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["farmingprogram.Properties.Settings.DbFarmProgramConnectionString"].ConnectionString; //Gets the Connection String from resources ('App.Config')
            connection = new SqlConnection(connectionString); //Creates a new connection
            try
            {
                connection.Open(); //Opens connection
            }
            catch (Exception ex)
            {
                //Any errors will leave program useless
                //So it shuts down
                MessageBox.Show("Error opening connection. Closing program.");
                Environment.Exit(0);
            }
        }

        //Getter for the sql connection
        public static SqlConnection getConnection()
        {
            return connection;
        }

        //Checks if password is valid with the arguments username, password they are both inputs from the user
        public static Boolean validPassword(String username, String password)
        {
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password)) //If the username and password is empty then Invalid credentials would be displayed
            {
                MessageBox.Show("Invalid credentials.");
                return false;
            }
            
            string queryString = "SELECT * FROM Login"; //Selects all data from login
            SqlDataReader command = new SqlCommand(queryString, getConnection()).ExecuteReader(); //Executes command

            try
            {
                while (command.Read()) //While the command still has a output
                {
                    String name = command.GetString(0).ToLower(); //Get username from database
                    String pass = command.GetString(1).ToLower(); //Get password from database
                    int rights = command.GetInt32(2); //Get rights from database

                    if (name.Equals(username.ToLower()) && pass.Equals(PasswordEncryption.Encrypt(password).ToLower())) //See if user and password match
                    {
                        Program.setLogin(new LoginDetail(name, pass, rights)); //Set login detail 
                        getConnection().Close();//Close connection
                        return true; //Return true if match
                    }
                }
                MessageBox.Show("Invalid username or password try again.");
            }
            finally
            {
                command.Close(); //Close command 
            }
            return false; //Return false if no matches
        }
    }
}
