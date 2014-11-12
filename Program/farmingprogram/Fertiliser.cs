//Coded by SID 1335132
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FertiliserProgram
{
    class Fertiliser
    {
        //Attributes
        public int FertilizerID;
        private string fertName;
        private string fertDose;
        private string fertNote; 

        public Fertiliser(int fertID, string fertname, string fertdose, string fertnote)
        {
           //constructors
            this.fertName = fertname;
            this.FertilizerID = fertID;
            this.fertDose = fertdose;
            this.fertNote = fertnote;

        }
        //properties
        public string FertDose
        {
            get { return fertDose; }
            set { fertDose = value; }
        }
    
        public string FertName
        {
            get { return fertName; }
            set { fertName = value; }
        }

        private int FertiliserID 
        {
            get { return FertilizerID; }
            set { FertilizerID = value; }   
        }

        public string FertNote
        {
            get { return fertNote; }
            set { fertNote = value; }
        }

    }
}