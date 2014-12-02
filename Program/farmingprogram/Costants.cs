using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmingprogram
{   //CREATED BY: 1312754
    //UPDATED BY:
    //Integrated by:
    class Costants
    {
        //SQL Statements for the Tables
        //Crops
        public static String CROP_DELETE_QUERY = "DELETE FROM Crop WHERE CropID = @CropId";
        public static String CROP_INSERT_QUERY = "INSERT INTO Crop (CropName, DatePanted, EstimatedHarvestDate, CropNotes, FertilizerID, CropStatus, LastDose, NextDose, DosedByStaff, CropStorageType, CropMinMax, FieldID) VALUES (@CropName, @DatePanted, @EstimatedHarvestDate, @CropNotes, @FertilizerID, @CropStatus, @LastDose, @NextDose, @DosedByStaff, @CropStorageType, @CropMinMax, @FieldID)";
        public static String CROP_SELECTALL_QUERY = "SELECT * FROM Crop";

        //Storage
        public static String STORAGE_DELETE_QUERY = "DELETE FROM Storage WHERE StorageID = @StorageID";
        public static String STORAGE_INSERT_QUERY = "INSERT INTO Storage (StorageName, StorageCapacity, StorageAvailable, StorageNote) VALUES (@StorageName, @StorageCapacity, @StorageAvailable, @StorageNote)";
        public static String STORAGE_SELECTALL_QUERY = "SELECT * FROM Storage";

        //Vehicles
        public static String VEHCILES_DELETE_QUERY = "DELETE FROM Vehicle WHERE VehicleID = @VehicleID";
        public static String VEHCILES_INSERT_QUERY = "INSERT INTO Vehicle (Type, Make, Model, Description, Capacity) VALUES (@Type, @Make, @Model, @Description, @Capacity)";
        public static String VEHCILES_SELECTALL_QUERY = "SELECT * FROM Vehicles";

        //Staff
        public static String STAFF_DELETE_QUERY = "DELETE FROM Staff WHERE StaffID = @StaffID";
        public static String STAFF_INSERT_QUERY = "INSERT INTO Staff (FirstName, LastName, Title, Rights) VALUES (@FirstName, @LastName, @Title, @Rights)";
        public static String STAFF_SELECTALL_QUERY = "SELECT * FROM Staff";

        //Container
        public static String CONTAINER_DELETE_QUERY = "DELETE FROM Container WHERE ContainerID = @ContainerID";
        public static String CONTAINER_INSERT_QUERY = "INSERT INTO Container (contName, contType, contSize) VALUES (@contName, @contType, @contSize)";
        public static String CONTAINER_SELECTALL_QUERY = "SELECT * FROM Container";

        //Harvest
        public static String HARVEST_DELETE_QUERY = "DELETE FROM Harvest WHERE HarvestID = @HarvestID)";
        public static String HARVEST_INSERT_QUERY = "INSERT INTO Harvest (HarvestStartDate, HarvestEndDate, StaffRequired, ContainerID, CropID, FieldID, StaffID, VehicleID, StorageID) VALUES (@HarvestStartDate, @HarvestEndDate, @StaffRequired, @ContainerID, @CropID, @FieldID, @StaffID, @VehicleID, @StorageID)";
        public static String HARVEST_SELECTALL_QUERY = "SELECT * FROM Harvest";

        //Fertilizer
        public static String FERTILIZER_DELETE_QUERY = "DELETE FROM Fertilizer WHERE FertilizerID = @FertilizerID)";
        public static String FERTILIZER_INSERT_QUERY = "INSERT INTO Fertilizer (fertName, fertDose, fertNote) VALUES (@fertName, @fertDose, @fertNote)";
        public static String FERTILIZER_SELECTALL_QUERY = "SELECT * FROM Fertilizer";

        //Field
        public static String FIELD_DELETE_QUERY = "DELETE FROM Field WHERE FieldID = @FieldID";
        public static String FIELD_INSERT_QUERY = "INSERT INTO Field (FieldName, FieldStatus, FieldNotes) VALUES (@FieldName, @FieldStatus, @FieldNotes)";
        public static String FIELD_SELECTALL_QUERY = "SELECT * FROM Field";

    }
}
