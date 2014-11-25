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


       
        }
    }
}
