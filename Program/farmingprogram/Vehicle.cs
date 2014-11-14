using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmingprogram
{   //CREATED BY pls add SID
    //Integrated by 1312754
    class Vehicle
    {
        //Attributes
        private int Capacity;
        private string Type, Make, Model, Description;
        
        //Constructor
        public Vehicle(string type, string make, string model, string description, int capacity)
        {
            this.Type = type; //Type constructor
            this.Make = make; //Make constructor
            this.Model = model; //Model constructor
            this.Description = description; //Description constructor
            this.Capacity = capacity; //Capacity constructor
        }

        //Properties
        public string type //Type properties
        {
            get { return Type; }
            set { Type = value; } 
        }
        
        public string make //Make properties
        {
            get { return Make; }
            set { Make = value; } 
        }

        public string model //Model properties 
        {
            get { return Model;}
            set { Model = value; } 
        }

        public string description //Description properties
        {
            get { return Description; }
            set { Description = value; } 
        }
        
        public int capacity //Capacity Properties 
        {
            get { return Capacity; }
            set { Capacity = value; } 
        }
    }
}
