using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Created by and modified by 1333187
namespace farmingprogram
{
    class FarmingDataSet
    {
        //Sql adapters which hold different update,insert,delete and select queries
        public static SqlDataAdapter cropDataAdapter; 
        public static SqlDataAdapter fertilizerAdapter;
        public static SqlDataAdapter fieldAdapter;
        public static SqlDataAdapter containerAdapter;
        public static SqlDataAdapter staffAdapter;
        public static SqlDataAdapter harvestAdapter;
        public static SqlDataAdapter vehicleAdapter;

        //Data tables when the select query is read they are saved on these tables
        public static DataTable cropDataTable;
        public static DataTable fertilizerDataTable;
        public static DataTable fieldDataTable;
        public static DataTable containerDataTable;
        public static DataTable staffDataTable;
        public static DataTable harvestDataTable;
        public static DataTable vehicleDataTable;

        #region Crop Set
        public static void initializeCropSet() //Initializes the crop data set
        {

            SqlConnector.getConnection().Open(); //Open connection
            cropDataAdapter = new SqlDataAdapter(); //Attach adapter to cropDataAdapter

            //Declare Adapter queries
            cropDataAdapter.SelectCommand = new SqlCommand(Constants.CROP_SELECTALL_QUERY, SqlConnector.getConnection()); 
            cropDataAdapter.DeleteCommand = new SqlCommand(Constants.CROP_DELETE_QUERY, SqlConnector.getConnection());
            cropDataAdapter.InsertCommand = new SqlCommand(Constants.CROP_INSERT_QUERY, SqlConnector.getConnection());

            //If the update command is just being added
            if (cropDataAdapter.UpdateCommand == null)
            {
                cropDataAdapter.UpdateCommand = new SqlCommand(Constants.CROP_UPDATE_QUERY, SqlConnector.getConnection()); //Add the update query
                setCropUpdateParams(); //Add the parameters for the update query
            }
            cropDataTable = new DataTable(); //Create a new crop data table
            cropDataAdapter.Fill(cropDataTable); //Populate the data table
            MainProgram.getSingleton().cropBindingSource.DataSource = cropDataTable; //Send the cropGridView to view the crop data table
            SqlConnector.getConnection().Close(); //Close connection
        }

        public static void addCrop(Crop crop) //Add a crop
        {
            //Parameters which are set when query is execute "@varName", value
            cropDataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@CropName", crop.cropName)); 
            cropDataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@DatePlanted", crop.datePlanted));
            cropDataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@EstimatedHarvestDate", crop.estimatedHarvestDate));
            cropDataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@CropNotes", crop.cropNotes));
            cropDataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@FertilizerID", crop.fertilizerID));
            cropDataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@CropStatus", crop.cropStatus));
            cropDataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@LastDose", crop.lastDose));
            cropDataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@NextDose", crop.nextDose));
            cropDataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@DosedByStaff", crop.dosedByStaff));
            cropDataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@CropStorageType", crop.cropStorageType));
            cropDataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@CropMinMax", crop.cropMinMax));
            cropDataAdapter.InsertCommand.Parameters.Add(new SqlParameter("@FieldID", crop.fieldID));

            try
            {
                SqlConnector.getConnection().Open(); //Open connection
                cropDataAdapter.InsertCommand.ExecuteNonQuery(); //Execute query
            }
            finally
            {
                cropDataAdapter.InsertCommand.Parameters.Clear(); //Clear params to avoid error
                SqlConnector.getConnection().Close(); //Close connection
            }
        }

        //Sets update params so when row is edited there is no need to input hardcoded values
        public static void setCropUpdateParams()
        {
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@CropName", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CropName", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@DatePlanted", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DatePlanted", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@EstimatedHarvestDate", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "EstimatedHarvestDate", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@CropNotes", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CropNotes", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@FertilizerID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FertilizerID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@CropStatus", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CropStatus", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@LastDose", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "LastDose", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@NextDose", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "NextDose", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@DosedByStaff", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DosedByStaff", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@CropStorageType", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CropStorageType", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@CropMinMax", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CropMinMax", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@FieldID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FieldID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_CropID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CropID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_CropName", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CropName", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_DatePlanted", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DatePlanted", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_EstimatedHarvestDate", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "EstimatedHarvestDate", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_CropNotes", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CropNotes", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_CropNotes", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CropNotes", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_FertilizerID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FertilizerID", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_FertilizerID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FertilizerID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_CropStatus", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CropStatus", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_LastDose", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "LastDose", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_LastDose", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "LastDose", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_NextDose", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "NextDose", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_NextDose", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "NextDose", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_DosedByStaff", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DosedByStaff", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_DosedByStaff", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DosedByStaff", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_CropStorageType", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CropStorageType", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_CropMinMax", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CropMinMax", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_FieldID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FieldID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            cropDataAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@CropID", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "CropID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        #endregion


        #region Harvest set

        public static void initializeHarvestSet()  //Initializes the harvest data set
        {
            SqlConnector.getConnection().Open(); //Open connection
            harvestAdapter = new SqlDataAdapter(); //Attach adapter to harvestAdapter

            //Declare Adapter queries
            harvestAdapter.SelectCommand = new SqlCommand(Constants.HARVEST_SELECTALL_QUERY, SqlConnector.getConnection());
            harvestAdapter.DeleteCommand = new SqlCommand(Constants.HARVEST_DELETE_QUERY, SqlConnector.getConnection());
            harvestAdapter.InsertCommand = new SqlCommand(Constants.HARVEST_INSERT_QUERY, SqlConnector.getConnection());

            //If the update command is just being added
            if (harvestAdapter.UpdateCommand == null)
            {
                harvestAdapter.UpdateCommand = new SqlCommand(Constants.HARVEST_UPDATE_QUERY, SqlConnector.getConnection()); //Add the update query
                setHarvestUpdateParams(); //Add the parameters for the update query
            }
            harvestDataTable = new DataTable(); //Create a new datatable
            harvestAdapter.Fill(harvestDataTable); //File harvest data table
            MainProgram.getSingleton().harvestBindingSource.DataSource = harvestDataTable; //The harvestGridView will now display the datatable
            SqlConnector.getConnection().Close(); //Close connection
        }

        public static void addHarvest(Harvest harvest) //Adding a harvest
        {
            //@HarvestStartDate, @HarvestEndDate, @StaffRequired, @ContainerID, @CropID, @FieldID, @StaffID, @VehicleID, @StorageID
            harvestAdapter.InsertCommand.Parameters.Add(new SqlParameter("@HarvestStartDate", harvest.harvestStartDate));
            harvestAdapter.InsertCommand.Parameters.Add(new SqlParameter("@HarvestEndDate", harvest.harvestEndDate));
            harvestAdapter.InsertCommand.Parameters.Add(new SqlParameter("@StaffRequired", harvest.staffRequired));
            harvestAdapter.InsertCommand.Parameters.Add(new SqlParameter("@ContainerID", harvest.containerID));
            harvestAdapter.InsertCommand.Parameters.Add(new SqlParameter("@CropID", harvest.cropID));
            harvestAdapter.InsertCommand.Parameters.Add(new SqlParameter("@FieldID", harvest.fieldID));
            harvestAdapter.InsertCommand.Parameters.Add(new SqlParameter("@VehicleID", harvest.vehicle));//This should be the vehicle id of the vehicle assigned to the harvest.
            try
            {
                SqlConnector.getConnection().Open(); //Open sql connection
                fertilizerAdapter.InsertCommand.ExecuteNonQuery(); //Execute query
            }
            finally
            {
                fertilizerAdapter.InsertCommand.Parameters.Clear(); //Clear params to avoid error
                SqlConnector.getConnection().Close(); //Close connection
            }
        }

        //Sets update params so when row is edited there is no need to input hardcoded values
        public static void setHarvestUpdateParams()
        {
            harvestAdapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@HarvestStartDate", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "HarvestStartDate", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@HarvestEndDate", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "HarvestEndDate", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@StaffRequired", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "StaffRequired", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@ContainerID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "ContainerID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@CropID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CropID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@FieldID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FieldID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@StaffID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "StaffID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@VehicleID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "VehicleID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@StorageID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "StorageID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_HarvestID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "HarvestID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_HarvestStartDate", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "HarvestStartDate", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_HarvestEndDate", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "HarvestEndDate", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_StaffRequired", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "StaffRequired", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_ContainerID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "ContainerID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_CropID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CropID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_FieldID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FieldID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_StaffID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "StaffID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_VehicleID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "VehicleID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_StorageID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "StorageID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            harvestAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@HarvestID", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "HarvestID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        #endregion

        #region Fertilizer set
        public static void initializeFertilizerSet() //Initializes the fertilizer dataset
        {
            SqlConnector.getConnection().Open(); //Open connection
            fertilizerAdapter = new SqlDataAdapter(); //Create a new adapter for fertilizer

            //Insert queries into adapter
            fertilizerAdapter.SelectCommand = new SqlCommand(Constants.FERTILIZER_SELECTALL_QUERY, SqlConnector.getConnection());
            fertilizerAdapter.DeleteCommand = new SqlCommand(Constants.FERTILIZER_DELETE_QUERY, SqlConnector.getConnection());
            fertilizerAdapter.InsertCommand = new SqlCommand(Constants.FERTILIZER_INSERT_QUERY, SqlConnector.getConnection());

            //Update command
            if (fertilizerAdapter.UpdateCommand == null)
            {
                fertilizerAdapter.UpdateCommand = new SqlCommand(Constants.FERTILIZER_UPDATE_QUERY, SqlConnector.getConnection()); //Add the update command
                setFertilizerUpdateParams(); //Set the update command params
            }
            fertilizerDataTable = new DataTable(); //New data table for fertilizer
            fertilizerAdapter.Fill(fertilizerDataTable); //populate data table
            MainProgram.getSingleton().fertilizerBindingSource.DataSource = fertilizerDataTable; //Display data table on the grid
            SqlConnector.getConnection().Close();
        }

        public static void addFertilizer(Fertilizer fertilizer)
        {
            fertilizerAdapter.InsertCommand.Parameters.Add(new SqlParameter("@fertName", fertilizer.fertName));
            fertilizerAdapter.InsertCommand.Parameters.Add(new SqlParameter("@fertDose", fertilizer.fertDose));
            fertilizerAdapter.InsertCommand.Parameters.Add(new SqlParameter("@fertNote", fertilizer.fertNote));
            try
            {
                SqlConnector.getConnection().Open();
                fertilizerAdapter.InsertCommand.ExecuteNonQuery();
            }
            finally
            {
                fertilizerAdapter.InsertCommand.Parameters.Clear();
                SqlConnector.getConnection().Close();
            }
        }

        //Sets update params so when row is edited there is no need to input hardcoded values
        private static void setFertilizerUpdateParams()
        {
            fertilizerAdapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            fertilizerAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@fertName", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "fertName", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            fertilizerAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@fertDose", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "fertDose", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            fertilizerAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@fertNote", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "fertNote", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            fertilizerAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_FertilizerID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FertilizerID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            fertilizerAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_fertName", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "fertName", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            fertilizerAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_fertDose", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "fertDose", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            fertilizerAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_fertNote", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "fertNote", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            fertilizerAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@FertilizerID", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "FertilizerID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        #endregion

        #region Vehicle set
        //Initializes vehicle set
        public static void initializeVehicleSet()
        {
            SqlConnector.getConnection().Open(); //Opens connection
            vehicleAdapter = new SqlDataAdapter(); //Binds vehicleAdapter to a new data adapter

            //Sets adapter commands
            vehicleAdapter.SelectCommand = new SqlCommand(Constants.VEHICLE_SELECTALL_QUERY, SqlConnector.getConnection());
            vehicleAdapter.DeleteCommand = new SqlCommand(Constants.VEHICLE_DELETE_QUERY, SqlConnector.getConnection());
            vehicleAdapter.InsertCommand = new SqlCommand(Constants.VEHICLE_INSERT_QUERY, SqlConnector.getConnection());

            //Sets update command and parameters
            if (vehicleAdapter.UpdateCommand != null)
            {
                vehicleAdapter.UpdateCommand = new SqlCommand(Constants.VEHICLE_UPDATE_QUERY, SqlConnector.getConnection());
                setVehicleUpdateParams();
            }

            //populates table with database data
            vehicleDataTable = new DataTable();
            vehicleAdapter.Fill(vehicleDataTable);

            //View the data on a grid
            MainProgram.getSingleton().vehicleBindingSource.DataSource = vehicleDataTable;
            SqlConnector.getConnection().Close(); //Close connection
        }

        //Add a new vehicle
        public static void addVehicle(Vehicle vehicle)
        {
            //Parameters which are set when query is execute
            vehicleAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Type", vehicle.type));
            vehicleAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Make", vehicle.make));
            vehicleAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Model", vehicle.model));
            vehicleAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Description", vehicle.description));
            vehicleAdapter.InsertCommand.Parameters.Add(new SqlParameter("@Capacity", vehicle.capacity));

            try
            {
                SqlConnector.getConnection().Open(); //Open connection
                vehicleAdapter.InsertCommand.ExecuteNonQuery(); //Execute query
            }
            finally
            {
                vehicleAdapter.InsertCommand.Parameters.Clear(); //Clear params to avoid error
                SqlConnector.getConnection().Close(); //Close connection
            }
        }

        //Adds variable parameters to update command
        static void setVehicleUpdateParams()
        {
            vehicleAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Type", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Type", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            vehicleAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Make", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Make", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            vehicleAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Model", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Model", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            vehicleAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Description", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Description", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            vehicleAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Capacity", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Capacity", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            vehicleAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_VehicleID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "VehicleID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            vehicleAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Type", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Type", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            vehicleAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Make", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Make", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            vehicleAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Model", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Model", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            vehicleAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_Description", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Description", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            vehicleAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Description", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Description", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            vehicleAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Capacity", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Capacity", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            vehicleAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@VehicleID", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "VehicleID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        #endregion

        public static int deleteFromTable(SqlDataAdapter adapter, String idParam, int id)
        {
            int returnCode = 0;
            try
            {
                SqlConnector.getConnection().Open();
                adapter.DeleteCommand.Parameters.Add(new SqlParameter(idParam, SqlDbType.Int)).Value = id;
                returnCode = adapter.DeleteCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show("Cannot delete the data, it is used on another table. Please delete this data first.");
            } 
            finally
            {
                adapter.DeleteCommand.Parameters.Clear();
                SqlConnector.getConnection().Close();
            }
            return returnCode;
        }

        

       

        //Sets update params so when row is edited there is no need to input hardcoded values
        private static void setFieldUpdateParams()
        {
            fieldAdapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            fieldAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@FieldName", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FieldName", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            fieldAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@FieldStatus", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FieldStatus", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            fieldAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@FieldNotes", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FieldNotes", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            fieldAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_FieldID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FieldID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            fieldAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_FieldName", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FieldName", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            fieldAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_FieldStatus", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FieldStatus", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            fieldAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_FieldNotes", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FieldNotes", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            fieldAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_FieldNotes", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "FieldNotes", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            fieldAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@FieldID", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "FieldID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }

        public static void initializeContainerSet()
        {
            SqlConnector.getConnection().Open();
            containerAdapter = new SqlDataAdapter();
            containerAdapter.SelectCommand = new SqlCommand(Constants.CONTAINER_SELECTALL_QUERY, SqlConnector.getConnection());
            containerAdapter.DeleteCommand = new SqlCommand(Constants.CONTAINER_DELETE_QUERY, SqlConnector.getConnection());
            containerAdapter.InsertCommand = new SqlCommand(Constants.CONTAINER_INSERT_QUERY, SqlConnector.getConnection());

            if (containerAdapter.UpdateCommand == null)
            {
                containerAdapter.UpdateCommand = new SqlCommand(Constants.CONTAINER_UPDATE_QUERY);
                setContainerUpdateParams();
            }

            containerDataTable = new DataTable();
            containerAdapter.Fill(containerDataTable);
            MainProgram.getSingleton().containerBindingSource.DataSource = containerDataTable;
            SqlConnector.getConnection().Close();
        }

        //Sets update params so when row is edited there is no need to input hardcoded values
        private static void setContainerUpdateParams()
        {
            containerAdapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            containerAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@contName", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "contName", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            containerAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@contType", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "contType", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            containerAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@contSize", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "contSize", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            containerAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_ContainerID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "ContainerID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            containerAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_contName", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "contName", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            containerAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_contType", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "contType", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            containerAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_contSize", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "contSize", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            containerAdapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@ContainerID", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "ContainerID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }


        public static void initializeStaffSet()
        {
            SqlConnector.getConnection().Open();
            staffAdapter = new SqlDataAdapter();
            staffAdapter.SelectCommand = new SqlCommand(Constants.STAFF_SELECTALL_QUERY, SqlConnector.getConnection());
            staffAdapter.DeleteCommand = new SqlCommand(Constants.STAFF_DELETE_QUERY, SqlConnector.getConnection());
            staffAdapter.InsertCommand = new SqlCommand(Constants.STAFF_INSERT_QUERY, SqlConnector.getConnection());
            staffDataTable = new DataTable();
            staffAdapter.Fill(staffDataTable);
            MainProgram.getSingleton().staffBindingSource.DataSource = staffDataTable;
            SqlConnector.getConnection().Close();
        }

        public static void initializeFieldSet()
        {
            SqlConnector.getConnection().Open();
            fieldAdapter = new SqlDataAdapter();
            fieldAdapter.SelectCommand = new SqlCommand(Constants.FIELD_SELECTALL_QUERY, SqlConnector.getConnection());
            fieldAdapter.DeleteCommand = new SqlCommand(Constants.FIELD_DELETE_QUERY, SqlConnector.getConnection());
            fieldAdapter.InsertCommand = new SqlCommand(Constants.FIELD_INSERT_QUERY, SqlConnector.getConnection());

            if (fieldAdapter.UpdateCommand == null)
            {
                fieldAdapter.UpdateCommand = new SqlCommand(Constants.FIELD_UPDATE_QUERY, SqlConnector.getConnection());
                setFieldUpdateParams();
            }
            fieldDataTable = new DataTable();
            fieldAdapter.Fill(fieldDataTable);
            MainProgram.getSingleton().fieldBindingSource.DataSource = fieldDataTable;
            SqlConnector.getConnection().Close();
        }

        public static void addField(Field field)
        {
            fieldAdapter.InsertCommand.Parameters.Add(new SqlParameter("@FieldName", field.fieldName));
            fieldAdapter.InsertCommand.Parameters.Add(new SqlParameter("@FieldStatus", field.fieldStatus));
            fieldAdapter.InsertCommand.Parameters.Add(new SqlParameter("@FieldNotes", field.fieldNotes));
            try
            {
                SqlConnector.getConnection().Open();
                fieldAdapter.InsertCommand.ExecuteNonQuery();
            }
            finally
            {
                fieldAdapter.InsertCommand.Parameters.Clear();
                SqlConnector.getConnection().Close();
            }
        }


        public static void addContainer(Container container)
        {
            containerAdapter.InsertCommand.Parameters.Add(new SqlParameter("@contName", container.contName));
            containerAdapter.InsertCommand.Parameters.Add(new SqlParameter("@contSize", container.contSize));
            containerAdapter.InsertCommand.Parameters.Add(new SqlParameter("@contType", container.contType));
            try
            {
                SqlConnector.getConnection().Open();
                containerAdapter.InsertCommand.ExecuteNonQuery();
            }
            finally
            {
                containerAdapter.InsertCommand.Parameters.Clear();
                SqlConnector.getConnection().Close();
            }
        }       

    }
}
