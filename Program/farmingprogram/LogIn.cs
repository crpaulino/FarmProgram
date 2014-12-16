using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmingprogram
{
    //CREATED BY: SP1062
    //LoginDetail represents a class with the username and password and rights.
    class LoginDetail
    {
        //Login username and password
        private string username, password;
        //Rights 0=Normal 1=Manager
        private int rights;

        //Constructor
        public LoginDetail(string username, string password, int rights)
        {
            this.username = username;
            this.password = password;
            this.rights = rights;
        }

        //Properties
        public int getRights()
        {
            return rights;
        }

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }

    }
}
