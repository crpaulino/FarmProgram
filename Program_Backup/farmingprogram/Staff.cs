using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmingprogram
{   //CREATED BY 1312754
    class Staff
    {
        //attribute
        private string FirstName, LastName, Title;
        private bool Manager;

        //Constructor
        public Staff(string FirstName, string LastName, string Title, bool Manager)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Title = Title;
            this.Manager = Manager;
        }

        //Properties
        public string firstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        public string lastName
        {
            get { return LastName; }
            set { LastName = value; }
        }

        public string title
        {
            get { return Title; }
            set { Title = value; }
        }

        public bool manager
        {
            get { return Manager; }
            set { Manager = value; }
        }
    }
}
