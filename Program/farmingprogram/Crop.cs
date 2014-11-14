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
        private string cropName, cropNotes, cropStatus, dosedByStaff, cropStorageType, cropMinMax;
        private DateTime datePlanted, estimatedHarvestDate, lastDose, nextDose;
        private int fertilizerID, fieldID; 

        //constructors
        public Crop (string cropName, DateTime datePlanted, DateTime estimatedHarvestDate, string cropNotes, int fertilizerID, string cropStatus, DateTime lastDose, DateTime nextDose, string dosedByStaff, string cropStorageType, string cropMinMax, int fieldID)
        {
            this.cropName = cropName; 
            this.datePlanted = datePlanted; 
			this.estimatedHarvestDate = estimatedHarvestDate; 
            this.cropNotes = cropNotes; 
            this.fertilizerID = fertilizerID;
            this.cropStatus = cropStatus;
            this.lastDose = lastDose;
            this.nextDose = nextDose;
            this.dosedByStaff = dosedByStaff;
            this.cropStorageType = cropStorageType;
            this.cropMinMax = cropMinMax;
            this.fieldID = fieldID;            
        }

        //properties
        public string CropName 
        {
            get { return cropName;} 
            set { cropName = value; }
        }

        public DateTime DatePlanted
        {
            get { return datePlanted; }
            set { datePlanted = value; }
        }

        public DateTime EstimatedHarvestDate
        {
            get { return estimatedHarvestDate; }
            set { estimatedHarvestDate = value; }
        }

        public string CropNotes
        {
            get { return cropNotes }
            set { cropNotes = value; }
        }

        public int FertilizerID
        {
            get { return fertilizerID; }
            set { fertilizerID = value; }
        }

        public string CropStatus
        {
            get { return cropStatus; }
            set { cropStatus = value; }
        }

        public DateTime LastDose
        {
            get { return lastDose; }
            set { lastDose = value; }
        }

        public DateTime NextDose
        {
            get { return nextDose; }
            set { nextDose = value; }
        }

        public string DosedByStaff
        {
            get { return dosedByStaff; }
            set { dosedByStaff = value; }
        }

        public string CropStorageType
        {
            get { return cropStorageType; }
            set { cropStorageType = value; }
        }

        public string CropMinMax    //Temperature
        {
            get { return cropMinMax; }
            set { cropMinMax = value; }
        }

        public int FieldID
        {
            get { return fieldID; }
            set { fieldID = value; }
        }
      
    }
}
