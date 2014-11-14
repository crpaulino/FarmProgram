using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//SP1062
namespace farmingprogram
{
    class LogIn
    {
        private string username, password;
        private int rights;

        public LogIn(string username, string password, int rights)
        {
            this.username = username;
            this.password = password;
            this.rights = rights;
        }

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
