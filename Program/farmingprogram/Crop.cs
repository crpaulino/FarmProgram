using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmingprogram
{
    //made by student 1311808
    //integrated by 1312754 & 1333187
    class Crop
    {
       //attributes         
        private string CropName, CropNotes, CropStatus, CropMinMax;
        private DateTime DatePlanted, EstimatedHarvestDate, LastDose, NextDose;
        private int FertilizerID, FieldID, CropID, DosedByStaffID, CropStorageType; 

        //constructors
        public Crop (int cropID, string cropName, DateTime datePlanted, DateTime estimatedHarvestDate, string cropNotes, int fertilizerID, string cropStatus, DateTime lastDose, DateTime nextDose, int dosedByStaff, int cropStorageType, string cropMinMax, int fieldID)
        {
            this.CropName = cropName; 
            this.DatePlanted = datePlanted; 
			this.EstimatedHarvestDate = estimatedHarvestDate; 
            this.CropNotes = cropNotes; 
            this.FertilizerID = fertilizerID;
            this.CropStatus = cropStatus;
            this.LastDose = lastDose;
            this.NextDose = nextDose;
            this.DosedByStaffID = dosedByStaff;
            this.CropStorageType = cropStorageType;
            this.CropMinMax = cropMinMax;
            this.FieldID = fieldID;
            this.CropID = cropID;
        }

        //properties
        public string cropName 
        {
            get { return CropName;} 
            set { CropName = value; }
        }

        public int cropId
        {
            get { return CropID; }
            set { CropID = value; }
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

        public int dosedByStaff
        {
            get { return DosedByStaffID; }
            set { DosedByStaffID = value; }
        }

        public int cropStorageType
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
