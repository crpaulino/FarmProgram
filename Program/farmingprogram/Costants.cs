using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmingprogram
{   //CREATED BY: 1312754
    //UPDATED BY:
    //Integrated by: 1333187
    class Constants
    {
        public static Boolean TESTING_MODE = false;

        //SQL Statements for the Tables
        //Crops
        public static String CROP_DELETE_QUERY = "DELETE FROM Crop WHERE CropID = @CropId";
        public static String CROP_INSERT_QUERY = "INSERT INTO Crop (CropName, DatePanted, EstimatedHarvestDate, CropNotes, FertilizerID, CropStatus, LastDose, NextDose, DosedByStaff, CropStorageType, CropMinMax, FieldID) VALUES (@CropName, @DatePanted, @EstimatedHarvestDate, @CropNotes, @FertilizerID, @CropStatus, @LastDose, @NextDose, @DosedByStaff, @CropStorageType, @CropMinMax, @FieldID)";
        public static String CROP_SELECTALL_QUERY = "SELECT * FROM Crop";
        public static String CROP_UPDATE_QUERY = @"UPDATE [dbo].[Crop] SET [CropName] = @CropName, [DatePlanted] = @DatePlanted, [EstimatedHarvestDate] = @EstimatedHarvestDate, [CropNotes] = @CropNotes, [FertilizerID] = @FertilizerID, [CropStatus] = @CropStatus, [LastDose] = @LastDose, [NextDose] = @NextDose, [DosedByStaff] = @DosedByStaff, [CropStorageType] = @CropStorageType, [CropMinMax] = @CropMinMax, [FieldID] = @FieldID WHERE (([CropID] = @Original_CropID) AND ([CropName] = @Original_CropName) AND ([DatePlanted] = @Original_DatePlanted) AND ([EstimatedHarvestDate] = @Original_EstimatedHarvestDate) AND ((@IsNull_CropNotes = 1 AND [CropNotes] IS NULL) OR ([CropNotes] = @Original_CropNotes)) AND ((@IsNull_FertilizerID = 1 AND [FertilizerID] IS NULL) OR ([FertilizerID] = @Original_FertilizerID)) AND ([CropStatus] = @Original_CropStatus) AND ((@IsNull_LastDose = 1 AND [LastDose] IS NULL) OR ([LastDose] = @Original_LastDose)) AND ((@IsNull_NextDose = 1 AND [NextDose] IS NULL) OR ([NextDose] = @Original_NextDose)) AND ((@IsNull_DosedByStaff = 1 AND [DosedByStaff] IS NULL) OR ([DosedByStaff] = @Original_DosedByStaff)) AND ([CropStorageType] = @Original_CropStorageType) AND ([CropMinMax] = @Original_CropMinMax) AND ([FieldID] = @Original_FieldID));
SELECT CropID, CropName, DatePlanted, EstimatedHarvestDate, CropNotes, FertilizerID, CropStatus, LastDose, NextDose, DosedByStaff, CropStorageType, CropMinMax, FieldID FROM Crop WHERE (CropID = @CropID)";
        
        //Storage (Don't need same as container)
        public static String STORAGE_DELETE_QUERY = "DELETE FROM Storage WHERE StorageID = @StorageID";
        public static String STORAGE_INSERT_QUERY = "INSERT INTO Storage (StorageName, StorageCapacity, StorageAvailable, StorageNote) VALUES (@StorageName, @StorageCapacity, @StorageAvailable, @StorageNote)";
        public static String STORAGE_SELECTALL_QUERY = "SELECT * FROM Storage";

        //Vehicles
        public static String VEHICLE_DELETE_QUERY = "DELETE FROM Vehicle WHERE VehicleID = @VehicleID";
        public static String VEHICLE_INSERT_QUERY = "INSERT INTO Vehicle (Type, Make, Model, Description, Capacity) VALUES (@Type, @Make, @Model, @Description, @Capacity)";
        public static String VEHICLE_SELECTALL_QUERY = "SELECT * FROM Vehicle";
        public static String VEHICLE_UPDATE_QUERY = @"UPDATE [dbo].[Vehicle] SET [Type] = @Type, [Make] = @Make, [Model] = @Model, [Description] = @Description, [Capacity] = @Capacity WHERE (([VehicleID] = @Original_VehicleID) AND ([Type] = @Original_Type) AND ([Make] = @Original_Make) AND ([Model] = @Original_Model) AND ((@IsNull_Description = 1 AND [Description] IS NULL) OR ([Description] = @Original_Description)) AND ([Capacity] = @Original_Capacity));
SELECT VehicleID, Type, Make, Model, Description, Capacity FROM Vehicle WHERE (VehicleID = @VehicleID)";

        //Staff
        public static String STAFF_DELETE_QUERY = "DELETE FROM Staff WHERE StaffID = @StaffID";
        public static String STAFF_INSERT_QUERY = "INSERT INTO Staff (FirstName, LastName, Title, Rights) VALUES (@FirstName, @LastName, @Title, @Rights)";
        public static String STAFF_SELECTALL_QUERY = "SELECT * FROM Staff";

        //Container
        public static String CONTAINER_DELETE_QUERY = "DELETE FROM Container WHERE ContainerID = @ContainerID";
        public static String CONTAINER_INSERT_QUERY = "INSERT INTO Container (contName, contType, contSize) VALUES (@contName, @contType, @contSize)";
        public static String CONTAINER_SELECTALL_QUERY = "SELECT * FROM Container";
        public static String CONTAINER_UPDATE_QUERY = @"UPDATE [dbo].[Container] SET [contName] = @contName, [contType] = @contType, [contSize] = @contSize WHERE (([ContainerID] = @Original_ContainerID) AND ([contName] = @Original_contName) AND ([contType] = @Original_contType) AND ([contSize] = @Original_contSize));
SELECT ContainerID, contName, contType, contSize FROM Container WHERE (ContainerID = @ContainerID)";

        //Harvest
        public static String HARVEST_DELETE_QUERY = "DELETE FROM Harvest WHERE HarvestID = @HarvestID)";
        public static String HARVEST_INSERT_QUERY = "INSERT INTO Harvest (HarvestStartDate, HarvestEndDate, StaffRequired, ContainerID, CropID, FieldID, VehicleID) VALUES (@HarvestStartDate, @HarvestEndDate, @StaffRequired, @ContainerID, @CropID, @FieldID, @VehicleID)";
        public static String HARVEST_SELECTALL_QUERY = "SELECT * FROM Harvest";
        public static String HARVEST_UPDATE_QUERY = @"UPDATE [dbo].[Harvest] SET [HarvestStartDate] = @HarvestStartDate, [HarvestEndDate] = @HarvestEndDate, [StaffRequired] = @StaffRequired, [ContainerID] = @ContainerID, [CropID] = @CropID, [FieldID] = @FieldID, [VehicleID] = @VehicleID WHERE (([HarvestID] = @Original_HarvestID) AND ([HarvestStartDate] = @Original_HarvestStartDate) AND ([HarvestEndDate] = @Original_HarvestEndDate) AND ([StaffRequired] = @Original_StaffRequired) AND ([ContainerID] = @Original_ContainerID) AND ([CropID] = @Original_CropID) AND ([FieldID] = @Original_FieldID) AND ([VehicleID] = @Original_VehicleID));
SELECT HarvestID, HarvestStartDate, HarvestEndDate, StaffRequired, ContainerID, CropID, FieldID, VehicleID FROM Harvest WHERE (HarvestID = @HarvestID)";

        //Fertilizer
        public static String FERTILIZER_DELETE_QUERY = "DELETE FROM Fertilizer WHERE FertilizerID = @FertilizerID";
        public static String FERTILIZER_INSERT_QUERY = "INSERT INTO Fertilizer (fertName, fertDose, fertNote) VALUES (@fertName, @fertDose, @fertNote)";
        public static String FERTILIZER_SELECTALL_QUERY = "SELECT * FROM Fertilizer";
        public static String FERTILIZER_UPDATE_QUERY = @"UPDATE [dbo].[Fertilizer] SET [fertName] = @fertName, [fertDose] = @fertDose, [fertNote] = @fertNote WHERE (([FertilizerID] = @Original_FertilizerID) AND ([fertName] = @Original_fertName) AND ([fertDose] = @Original_fertDose) AND ([fertNote] = @Original_fertNote));
SELECT FertilizerID, fertName, fertDose, fertNote FROM Fertilizer WHERE (FertilizerID = @FertilizerID)";

        //Field
        public static String FIELD_DELETE_QUERY = "DELETE FROM Field WHERE FieldID = @FieldID";
        public static String FIELD_INSERT_QUERY = "INSERT INTO Field (FieldName, FieldStatus, FieldNotes) VALUES (@FieldName, @FieldStatus, @FieldNotes)";
        public static String FIELD_SELECTALL_QUERY = "SELECT * FROM Field";
        public static String FIELD_UPDATE_QUERY = @"UPDATE [dbo].[Harvest] SET [HarvestStartDate] = @HarvestStartDate, [HarvestEndDate] = @HarvestEndDate, [StaffRequired] = @StaffRequired, [ContainerID] = @ContainerID, [CropID] = @CropID, [FieldID] = @FieldID, [VehicleID] = @VehicleID WHERE (([HarvestID] = @Original_HarvestID) AND ([HarvestStartDate] = @Original_HarvestStartDate) AND ([HarvestEndDate] = @Original_HarvestEndDate) AND ([StaffRequired] = @Original_StaffRequired) AND ([ContainerID] = @Original_ContainerID) AND ([CropID] = @Original_CropID) AND ([FieldID] = @Original_FieldID) AND ([StaffID] = @Original_StaffID) AND ([VehicleID] = @Original_VehicleID) AND ([StorageID] = @Original_StorageID));
SELECT HarvestID, HarvestStartDate, HarvestEndDate, StaffRequired, ContainerID, CropID, FieldID, StaffID, VehicleID, StorageID FROM Harvest WHERE (HarvestID = @HarvestID)";
    }
}
