using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Class
{
    //MADE BY 1307211
    class Storage
    {
       //attribute
        private int id, capacity, available;
        private string name, note;

        //constructor
        public Storage (int id, int capacity, string name, int available, string note)
        {
            this.id = id; //id constructor
            this.name = name; //name constructor
            this.capacity = capacity; //capacity constructor
            this.available = available; //availability constructor
            this.note = note; //note constructor
            
        }

        //properties
        public int Id //id property
        {
            get { return id;} //gets id
            set { id = value; } //sets the id value
        }

        public string Name //Name properties
        {
            get { return name; } //gets name 
            set { name = value; }//sets the value
        }

        public int Capacity //capacity property
        {
            get { return capacity; } //gets the capacity
            set { capacity = value; }//sets the value
        }

        public int Available //availablity property
        {
            get { return available; }//gets the available
            set { available = value; }//sets the value
        }

        public string Note //note property
        {
            get { return note; }//gets the note
            set { note = value; }//sets the value
        }
    }
}
