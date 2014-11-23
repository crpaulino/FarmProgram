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
        private static SqlConnection connection = null;

        public static void startConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["farmingprogram.Properties.Settings.DbFarmProgramConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening connection. Closing program.");
                Environment.Exit(0);
            }
        }

        public static SqlConnection getConnection()
        {
            return connection;
        }

        public static Boolean validPassword(String username, String password)
        {
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Invalid credentials.");
                return false;
            }
            
            string queryString = "SELECT * FROM Login";
            SqlDataReader command = new SqlCommand(queryString, getConnection()).ExecuteReader();

            try
            {
                while (command.Read())
                {
                    String name = command.GetString(0).ToLower();
                    String pass = command.GetString(1).ToLower();
                    int rights = command.GetInt32(2);

                    if (name.Equals(username.ToLower()) && pass.Equals(PasswordEncryption.Encrypt(password).ToLower()))
                    {
                        Program.setLogin(new LoginDetail(name, pass, rights));
                        getConnection().Close();
                        return true;
                    }
                }
                MessageBox.Show("Invalid username or password try again.");
            }
            finally
            {
                command.Close();
            }
            return false;
        }
    }
}
