using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmingprogram
{   //CREATED BY 1312754
    class Harvest
    {
        //Attributes         
        private DateTime HarvestStartDate, HarvestEndDate;
        private int StaffRequired, ContainerID, CropID, FieldID, StaffID, VehicleID, StorageID; 

        //Constructors
        public Harvest (DateTime HarvestStartDate, DateTime HarvestEndDate, int StaffRequired, int ContainerID, int CropID, int FieldID, int StaffID, int VehicleID, int StorageID)
        {
            this.HarvestStartDate = HarvestStartDate; 
            this.HarvestEndDate = HarvestEndDate; 
			this.StaffRequired = StaffRequired; 
            this.ContainerID = ContainerID; 
            this.CropID = CropID;
            this.FieldID = FieldID;
            this.StaffID = StaffID;
            this.VehicleID = VehicleID;
            this.StorageID = StorageID;          
        }

        //Properties
        public DateTime harvestStartDate
        {
            get { return HarvestStartDate;} 
            set { HarvestStartDate = value; }
        }

        public DateTime harvestEndDate
        {
            get { return HarvestEndDate; }
            set { HarvestEndDate = value; }
        }

        public int staffRequired//How many of the Staff will be required for the harvest.
        {
            get { return StaffRequired; }
            set { StaffRequired= value; }
        }

        public int containerID
        {
            get { return ContainerID; }
            set { ContainerID = value; }
        }

        public int cropID
        {
            get { return CropID; }
            set { CropID = value; }
        }

        public int fieldID
        {
            get { return FieldID; }
            set { FieldID = value; }
        }

        public int staffID
        {
            get { return StaffID; }
            set { StaffID = value; }
        }

        public int vehicle
        {
            get { return VehicleID; }
            set { VehicleID = value; }
        }

        public int storageID
        {
            get { return StorageID; }
            set { StorageID = value; }
        }
    }
}
