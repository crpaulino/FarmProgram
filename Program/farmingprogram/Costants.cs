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
        String CROP_DELETE_QUERY = "DELETE FROM Crop Where CropID=@cropId";
        String CROP_INSERT_QUERY = "";
        String CROP_UPDATE_QUERY = "";
        //Storage (Mark)
        String STORAGE_DELETE_QUERY = "";
        String STORAGE_INSERT_QUERY = "";
        String STORAGE_UPDATE_QUERY = "";

        //Vehicles (Mark)
        String VEHCILES_DELETE_QUERY = "";
        String VEHCILES_INSERT_QUERY = "";
        String VEHCILES_UPDATE_QUERY = "";

        //Staff (Carlos)
        String STAFF_DELETE_QUERY = "";
        String STAFF_INSERT_QUERY = "";
        String STAFF_UPDATE_QUERY = "";

        //Container (Carlos and Sanjay)
        String CONTAINER_DELETE_QUERY = "";
        String CONTAINER_INSERT_QUERY = "";
        String CONTAINER_UPDATE_QUERY = "";

        //Harvest (Carlos)
        String HARVEST_DELETE_QUERY = "";
        String HARVEST_INSERT_QUERY = "";
        String HARVEST_UPDATE_QUERY = "";

        //Fertilizer (Thomas and Sanjay)
        String FERTILIZER_DELETE_QUERY = "";
        String FERTILIZER_INSERT_QUERY = "";
        String FERTILIZER_UPDATE_QUERY = "";

        //Field (Thomas)
        String FIELD_DELETE_QUERY = "";
        String FIELD_INSERT_QUERY = "";
        String FIELD_UPDATE_QUERY = "";

    }
}
