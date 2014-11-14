using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmingprogram
{
    //made by student 1311808
    //integrated by 1312754
    class Crop
    {
       //attributes         
        private string CropName, CropNotes, CropStatus, DosedByStaff, CropStorageType, CropMinMax;
        private DateTime DatePlanted, EstimatedHarvestDate, LastDose, NextDose;
        private int FertilizerID, FieldID; 

        //constructors
        public Crop (string cropName, DateTime datePlanted, DateTime estimatedHarvestDate, string cropNotes, int fertilizerID, string cropStatus, DateTime lastDose, DateTime nextDose, string dosedByStaff, string cropStorageType, string cropMinMax, int fieldID)
        {
            this.CropName = cropName; 
            this.DatePlanted = datePlanted; 
			this.EstimatedHarvestDate = estimatedHarvestDate; 
            this.CropNotes = cropNotes; 
            this.FertilizerID = fertilizerID;
            this.CropStatus = cropStatus;
            this.LastDose = lastDose;
            this.NextDose = nextDose;
            this.DosedByStaff = dosedByStaff;
            this.CropStorageType = cropStorageType;
            this.CropMinMax = cropMinMax;
            this.FieldID = fieldID;            
        }

        //properties
        public string cropName 
        {
            get { return CropName;} 
            set { CropName = value; }
        }

        public DateTime datePlanted
        {
            get { return DatePlanted; }
            set { DatePlanted = value; }
        }

        public DateTime estimatedHarvestDate
        {
            get { return EstimatedHarvestDate; }
            set { EstimatedHarvestDate = value; }
        }

        public string cropNotes
        {
            get { return CropNotes; }
            set { CropNotes = value; }
        }

        public int fertilizerID
        {
            get { return FertilizerID; }
            set { FertilizerID = value; }
        }

        public string cropStatus
        {
            get { return CropStatus; }
            set { CropStatus = value; }
        }

        public DateTime lastDose
        {
            get { return LastDose; }
            set { LastDose = value; }
        }

        public DateTime nextDose
        {
            get { return NextDose; }
            set { NextDose = value; }
        }

        public string dosedByStaff
        {
            get { return DosedByStaff; }
            set { DosedByStaff = value; }
        }

        public string cropStorageType
        {
            get { return CropStorageType; }
            set { CropStorageType = value; }
        }

        public string cropMinMax    //Temperature
        {
            get { return CropMinMax; }
            set { CropMinMax = value; }
        }

        public int fieldID
        {
            get { return FieldID; }
            set { FieldID = value; }
        }
      
    }
}
