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
        public static SqlDataAdapter fertilizerDataAdapter;
        public static SqlDataAdapter fieldDataAdapter;
        //public static SqlDataAdapter containerDataAdapter;

        public static DataSet initializeCropSet()
        {
            //start the connection
            SqlConnector.startConnection();

            cropDataAdapter = new SqlDataAdapter();
            cropDataAdapter.SelectCommand = new SqlCommand(Costants.CROP_UPDATE_QUERY, SqlConnector.getConnection());
            cropDataAdapter.DeleteCommand = new SqlCommand(Costants.CROP_DELETE_QUERY, SqlConnector.getConnection());
            cropDataAdapter.InsertCommand = new SqlCommand(Costants.CROP_INSERT_QUERY, SqlConnector.getConnection());

            // crate the dataset
            DataSet dsCrop = new DataSet();

            //fill in the dataset with the data coming from the dataAdapter
            cropDataAdapter.Fill(dsCrop);

            //close the connection
            SqlConnector.getConnection().Close();
            return dsCrop;
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

        public static DataSet initializeFertilizerSet() //made by 1307211
        {
            //start the connection
            SqlConnector.startConnection();

            fertilizerDataAdapter = new SqlDataAdapter();
            fertilizerDataAdapter.SelectCommand = new SqlCommand(Costants.FERTILIZER_UPDATE_QUERY, SqlConnector.getConnection());
            fertilizerDataAdapter.DeleteCommand = new SqlCommand(Costants.FERTILIZER_DELETE_QUERY, SqlConnector.getConnection());
            fertilizerDataAdapter.InsertCommand = new SqlCommand(Costants.FERTILIZER_INSERT_QUERY, SqlConnector.getConnection());

            // create the dataset
            DataSet dsFertilizer = new DataSet();

            //fill in the dataset with the data coming from the dataAdapter
            fertilizerDataAdapter.Fill(dsFertilizer);

            //close the connection
            SqlConnector.getConnection().Close();
            return dsFertilizer;
        }

        public static int deleteFertilizer(int fertilizerId)
        {
            int returnCode = 0;
            try
            {
                SqlConnector.getConnection().Open();
                fertilizerDataAdapter.DeleteCommand.Parameters.AddWithValue("@FertilizerID", fertilizerId);
                returnCode = fertilizerDataAdapter.DeleteCommand.ExecuteNonQuery();
            }
            finally
            {
                SqlConnector.getConnection().Close();
            }
            return returnCode;
        }

        public static DataSet initializeFieldSet() //made by 1311808
        {
            //start the connection
            SqlConnector.startConnection();

            fieldDataAdapter = new SqlDataAdapter();
            fieldDataAdapter.SelectCommand = new SqlCommand(Costants.FIELD_UPDATE_QUERY, SqlConnector.getConnection());
            fieldDataAdapter.DeleteCommand = new SqlCommand(Costants.FIELD_DELETE_QUERY, SqlConnector.getConnection());
            fieldDataAdapter.InsertCommand = new SqlCommand(Costants.FIELD_INSERT_QUERY, SqlConnector.getConnection());

            // create the dataset
            DataSet dsField = new DataSet();

            //fill in the dataset with the data coming from the dataAdapter
            fieldDataAdapter.Fill(dsField);

            //close the connection
            SqlConnector.getConnection().Close();
            return dsField;
        }

        public static int deleteField(int fieldId)
        {
            int returnCode = 0;
            try
            {
                SqlConnector.getConnection().Open();
                fieldDataAdapter.DeleteCommand.Parameters.AddWithValue("@FieldID", fieldId);
                returnCode = fieldDataAdapter.DeleteCommand.ExecuteNonQuery();
            }
            finally
            {
                SqlConnector.getConnection().Close();
            }
            return returnCode;
        }
    }
}
