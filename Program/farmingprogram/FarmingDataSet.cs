using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmingprogram
{
    class FarmingDataSet
    {
        public static SqlDataAdapter cropDataAdapter;
        public static SqlDataAdapter fertilizerAdapter;
        public static SqlDataAdapter fieldAdapter;
        public static SqlDataAdapter containerAdapter;
        public static SqlDataAdapter staffAdapter;
        public static SqlDataAdapter vehicleAdapter;

        public static DataTable cropDataTable;
        public static DataTable fertilizerDataTable;
        public static DataTable fieldDataTable;
        public static DataTable containerDataTable;
        public static DataTable staffDataTable;
        public static DataTable vehicleDataTable;

        public static void initializeCropSet()
        {

            SqlConnector.getConnection().Open();
            cropDataAdapter = new SqlDataAdapter();
            cropDataAdapter.SelectCommand = new SqlCommand(Constants.CROP_SELECTALL_QUERY, SqlConnector.getConnection());
            cropDataAdapter.DeleteCommand = new SqlCommand(Constants.CROP_DELETE_QUERY, SqlConnector.getConnection());
            cropDataAdapter.InsertCommand = new SqlCommand(Constants.CROP_INSERT_QUERY, SqlConnector.getConnection());
            cropDataTable = new DataTable();
            cropDataAdapter.Fill(cropDataTable);
            MainProgram.getSingleton().cropBindingSource.DataSource = cropDataTable;
            SqlConnector.getConnection().Close();
        }
        
        public static int deleteCrop(int cropId)
        {
            int returnCode = 0;
            try
            {
                SqlConnector.getConnection().Open();
                cropDataAdapter.DeleteCommand.Parameters.Add(new SqlParameter("@CropID", SqlDbType.Int)).Value = cropId;
                returnCode = cropDataAdapter.DeleteCommand.ExecuteNonQuery();
            }
            finally
            {
                cropDataAdapter.DeleteCommand.Parameters.Clear();
                SqlConnector.getConnection().Close();
            }
            return returnCode;
        }

        public static void addCrop(Crop crop)
        {
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
                SqlConnector.getConnection().Open();
                cropDataAdapter.InsertCommand.ExecuteNonQuery();
            }
            finally
            {
                cropDataAdapter.InsertCommand.Parameters.Clear();
                SqlConnector.getConnection().Close();
            }
        }

        public static void initializeFertilizerSet()
        {
            SqlConnector.getConnection().Open();
            fertilizerAdapter = new SqlDataAdapter();
            fertilizerAdapter.SelectCommand = new SqlCommand(Constants.FERTILIZER_SELECTALL_QUERY, SqlConnector.getConnection());
            fertilizerAdapter.DeleteCommand = new SqlCommand(Constants.FERTILIZER_DELETE_QUERY, SqlConnector.getConnection());
            fertilizerAdapter.InsertCommand = new SqlCommand(Constants.FERTILIZER_INSERT_QUERY, SqlConnector.getConnection());
            fertilizerDataTable = new DataTable();
            fertilizerAdapter.Fill(fertilizerDataTable);
            MainProgram.getSingleton().fertilizerBindingSource.DataSource = fertilizerDataTable;
            SqlConnector.getConnection().Close();
        }

        public static void initializeFieldSet()
        {
            SqlConnector.getConnection().Open();
            fieldAdapter = new SqlDataAdapter();
            fieldAdapter.SelectCommand = new SqlCommand(Constants.FIELD_SELECTALL_QUERY, SqlConnector.getConnection());
            fieldAdapter.DeleteCommand = new SqlCommand(Constants.FIELD_DELETE_QUERY, SqlConnector.getConnection());
            fieldAdapter.InsertCommand = new SqlCommand(Constants.FIELD_INSERT_QUERY, SqlConnector.getConnection());
            fieldDataTable = new DataTable();
            fieldAdapter.Fill(fieldDataTable);
            MainProgram.getSingleton().fieldBindingSource.DataSource = fieldDataTable;
            SqlConnector.getConnection().Close();
        }

        public static void initializeContainerSet()
        {
            SqlConnector.getConnection().Open();
            containerAdapter = new SqlDataAdapter();
            containerAdapter.SelectCommand = new SqlCommand(Constants.CONTAINER_SELECTALL_QUERY, SqlConnector.getConnection());
            containerAdapter.DeleteCommand = new SqlCommand(Constants.CONTAINER_DELETE_QUERY, SqlConnector.getConnection());
            containerAdapter.InsertCommand = new SqlCommand(Constants.CONTAINER_INSERT_QUERY, SqlConnector.getConnection());
            containerDataTable = new DataTable();
            containerAdapter.Fill(containerDataTable);
            MainProgram.getSingleton().containerBindingSource.DataSource = containerDataTable;
            SqlConnector.getConnection().Close();
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

        public static void initializeVehicleSet()
        {
            SqlConnector.getConnection().Open();
            vehicleAdapter = new SqlDataAdapter();
            vehicleAdapter.SelectCommand = new SqlCommand(Constants.VEHICLES_SELECTALL_QUERY, SqlConnector.getConnection());
            vehicleAdapter.DeleteCommand = new SqlCommand(Constants.VEHICLES_DELETE_QUERY, SqlConnector.getConnection());
            vehicleAdapter.InsertCommand = new SqlCommand(Constants.VEHICLES_INSERT_QUERY, SqlConnector.getConnection());
            vehicleDataTable = new DataTable();
            vehicleAdapter.Fill(vehicleDataTable);
            MainProgram.getSingleton().vehicleBindingSource.DataSource = vehicleDataTable;
            SqlConnector.getConnection().Close();
        }
    }
}
