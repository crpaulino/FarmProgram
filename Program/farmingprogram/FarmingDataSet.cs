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

        public static void initializeCropSet()
        {
            
            SqlConnector.getConnection().Open();
            cropDataAdapter = new SqlDataAdapter();
            cropDataAdapter.SelectCommand = new SqlCommand(Costants.CROP_UPDATE_QUERY, SqlConnector.getConnection());
            cropDataAdapter.DeleteCommand = new SqlCommand(Costants.CROP_DELETE_QUERY, SqlConnector.getConnection());
            cropDataAdapter.InsertCommand = new SqlCommand(Costants.CROP_INSERT_QUERY, SqlConnector.getConnection());
            DataTable table = new DataTable();
            cropDataAdapter.Fill(table);
            MainProgram.getSingleton().cropBindingSource.DataSource = table;
            SqlConnector.getConnection().Close();
        }

        public static int deleteCrop(int cropId)
        {
            int returnCode = 0;
            try
            {
                SqlConnector.getConnection().Open();
                cropDataAdapter.DeleteCommand.Parameters.AddWithValue("@CropID", cropId);
                returnCode = cropDataAdapter.DeleteCommand.ExecuteNonQuery();
            }
            finally
            {
                SqlConnector.getConnection().Close();
            }
            return returnCode;
        }


        public static void initializeFertilizerSet()
        {
            SqlConnector.getConnection().Open();
            fertilizerAdapter = new SqlDataAdapter();
            fertilizerAdapter.SelectCommand = new SqlCommand(Costants.FERTILIZER_UPDATE_QUERY, SqlConnector.getConnection());
            fertilizerAdapter.DeleteCommand = new SqlCommand(Costants.FERTILIZER_DELETE_QUERY, SqlConnector.getConnection());
            fertilizerAdapter.InsertCommand = new SqlCommand(Costants.FERTILIZER_INSERT_QUERY, SqlConnector.getConnection());
            DataTable table = new DataTable();
            fertilizerAdapter.Fill(table);
            MainProgram.getSingleton().fertilizerBindingSource.DataSource = table;
            SqlConnector.getConnection().Close();
        }

        public static void initializeFieldSet()
        {
            SqlConnector.getConnection().Open();
            fieldAdapter = new SqlDataAdapter();
            fieldAdapter.SelectCommand = new SqlCommand(Costants.FIELD_UPDATE_QUERY, SqlConnector.getConnection());
            fieldAdapter.DeleteCommand = new SqlCommand(Costants.FIELD_DELETE_QUERY, SqlConnector.getConnection());
            fieldAdapter.InsertCommand = new SqlCommand(Costants.FIELD_INSERT_QUERY, SqlConnector.getConnection());
            DataTable table = new DataTable();
            fieldAdapter.Fill(table);
            MainProgram.getSingleton().fieldBindingSource.DataSource = table;
            SqlConnector.getConnection().Close();
        }

        public static void initializeContainerSet()
        {
            SqlConnector.getConnection().Open();
            containerAdapter = new SqlDataAdapter();
            containerAdapter.SelectCommand = new SqlCommand(Costants.CONTAINER_UPDATE_QUERY, SqlConnector.getConnection());
            containerAdapter.DeleteCommand = new SqlCommand(Costants.CONTAINER_DELETE_QUERY, SqlConnector.getConnection());
            containerAdapter.InsertCommand = new SqlCommand(Costants.CONTAINER_INSERT_QUERY, SqlConnector.getConnection());
            DataTable table = new DataTable();
            containerAdapter.Fill(table);
            //MainProgram.getSingleton().containerBindingSource.DataSource = table;
            SqlConnector.getConnection().Close();
        }
    }
}
