using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Class
{
    class Vehicle
    { //attributes
        private int id, capacity; //vehicle ID and capacity
        private string type, name, make, model, description;//Vehicle type, name, make,model and description
        
        //constructor
        public Vehicle(int id, string name, string type, string make, string model, string description, int capacity)
        {
            this.id = id; //ID constructor
            this.name = name; //Name constructor
            this.type = type; //Type constructor
            this.make = make; //Make constructor
            this.model = model; //Model constructor
            this.description = description; //Description constructor
            this.capacity = capacity; //Capacity constructor
        }

        public int ID //ID properties
        {
            get { return id; }
            set { id = value; }
        }

        public string Name //Name properties
        {
            get { return name; }
            set { name = value; } 
        }

        public string Type //Type properties
        {
            get { return type; }
            set { type = value; } 
        }
        
        public string Make //Make properties
        {
            get { return make; }
            set { make = value; } 
        }

        public string Model //Model properties 
        {
            get { return model;}
            set { model = value; } 
        }

        public string Description //Description properties
        {
            get { return description; }
            set { description = value; } 
        }
        
        public int Capacity //Capacity Properties 
        {
            get { return capacity; }
            set { capacity = value; } 
        }
    }
    
}
