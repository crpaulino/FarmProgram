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
        private int harvestID, StaffRequired, ContainerID, CropID, FieldID, VehicleID;
        //Constructors
        public Harvest(int HarvestID, DateTime HarvestStartDate, DateTime HarvestEndDate, int StaffRequired, int ContainerID, int CropID, int FieldID, int VehicleID)
        {
            this.harvestID = HarvestID;
            this.HarvestStartDate = HarvestStartDate;
            this.HarvestEndDate = HarvestEndDate;
            this.StaffRequired = StaffRequired;
            this.ContainerID = ContainerID;
            this.CropID = CropID;
            this.FieldID = FieldID;
            this.VehicleID = VehicleID;
        }

        //Properties
        public DateTime harvestStartDate
        {
            get { return HarvestStartDate; }
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
            set { StaffRequired = value; }
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

        public int HarvestID
        {
            get { return harvestID; }
            set { harvestID = value; }
        }

        public int fieldID
        {
            get { return FieldID; }
            set { FieldID = value; }
        }

        public int vehicle
        {
            get { return VehicleID; }
            set { VehicleID = value; }
        }
    }
}
