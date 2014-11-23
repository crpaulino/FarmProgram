using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmingprogram
{
    class Costants
    {
        //Crops (Shannon and Sanjay)
        public static String CROP_DELETE_QUERY = @"DELETE FROM Crop Where CropID = @cropId";
        public static String CROP_INSERT_QUERY = "";
        public static String CROP_UPDATE_QUERY = @"SELECT * FROM Crop";
        //Storage (Mark)
        public static String STORAGE_DELETE_QUERY = "";
        public static String STORAGE_INSERT_QUERY = "";
        public static String STORAGE_UPDATE_QUERY = @"SELECT * FROM Storage";

        //Vehicles (Mark)
        public static String VEHCILES_DELETE_QUERY = "";
        public static String VEHCILES_INSERT_QUERY = "";
        public static String VEHCILES_UPDATE_QUERY = @"SELECT * FROM VEHICLES";

        //Staff (Carlos)
        public static String STAFF_DELETE_QUERY = "";
        public static String STAFF_INSERT_QUERY = "";
        public static String STAFF_UPDATE_QUERY = @"SELECT * FROM Staff";

        //Container (Carlos and Sanjay)
        public static String CONTAINER_DELETE_QUERY = "";
        public static String CONTAINER_INSERT_QUERY = "";
        public static String CONTAINER_UPDATE_QUERY = @"SELECT FROM Container";

        //Harvest (Carlos)
        public static String HARVEST_DELETE_QUERY = @"DELETE FROM [Harvest] WHERE ([HarvestID] = @Original_HarvestID)";
        public static String HARVEST_INSERT_QUERY = "";
        public static String HARVEST_UPDATE_QUERY = @"SELECT * FROM Harvest";

        //Fertilizer (Thomas and Sanjay)
        public static String FERTILIZER_DELETE_QUERY = @"DELETE FROM [Fertilizer] WHERE ([FertilizerID] = @Original_FertilizerID)";
        public static String FERTILIZER_INSERT_QUERY = "";
        public static String FERTILIZER_UPDATE_QUERY = @"SELECT * FROM Fertilizer";

        //Field (Thomas)
        public static String FIELD_DELETE_QUERY = "";
        public static String FIELD_INSERT_QUERY = "";
        public static String FIELD_UPDATE_QUERY = @"SELECT * FROM Field";

    }
}
