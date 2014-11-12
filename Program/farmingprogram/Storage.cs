using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Class
{
    class Storage
    {
       //attribute
        private int id, capacity, available;
        private string name, note;

        //contructor
        public Storage (int id, int capacity, string name, int available, string note)
        {
            this.id = id;
            this.name = name;
            this.capacity = capacity;
            this.available = available;
            this.note = note;
            
        }

        public int Id
        {
            get { return id;}
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public int Available
        {
            get { return available; }
            set { available = value; }
        }

        public string Note
        {
            get { return note; }
            set { note = value; }
        }
    }
}
