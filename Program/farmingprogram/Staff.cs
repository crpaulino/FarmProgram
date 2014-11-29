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
        private int staffId, rights;
        private string firstName, lastName, title;

        //Constructor
        public Staff(int staffId, string firstName, string lastName, string title, int rights)
        {
            this.staffId = staffId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.title = title;
            this.rights = rights;
        }

        //Properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int Rights
        {
            get { return rights; }
            set { rights = value; }
        }

        public int StaffID
        {
            get { return staffId; }
            set { staffId = value; }
        }
    }
}
