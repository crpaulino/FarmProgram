using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmingprogram
{   //MADE BY: pls add
    //Integrated by 1312754

    class Fertilizer
    {
        //Attributes
        private int FertilizerID;
        private string FertName;
        private string FertDose;
        private string FertNote; 

        //constructors
        public Fertilizer(int fertilizerId, string fertname, string fertdose, string fertnote)
        {
            this.FertName = fertname;
            this.FertDose = fertdose;
            this.FertNote = fertnote;
            this.FertilizerID = fertilizerId;

        }
        //properties    
        public string fertName
        {
            get { return FertName; }
            set { FertName = value; }
        }

        public int fertilizerId
        {
            get { return fertilizerId; }
            set { fertilizerId = value; }
        }

        public string fertDose
        {
            get { return FertDose; }
            set { FertDose = value; }
        }

        public string fertNote
        {
            get { return FertNote; }
            set { FertNote = value; }
        }
    }
}
