using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Class
{
    class VehicleConstants
    {
        //SQL statements

        public static string selectAll = "SELECT * FROM Vehicles";
        public static string selectNames = "Select Name FROM Vehicles";
        public static string addRow = "INSERT INTO Vehickles (Name, Type, Make, Model, Description)";
        public static string deleteRow = "DELETE FROM Vechiles WHERE ID = @ID";

        //error messages

        public static string errorInsertInTableStr = "The row wasn't added"; //Adding row error 
        public static string errorDeleteRowFromTableStr = "The row you have chosen to delete hasn't been deleted"; //Delete row error

        //error code
        public static int errorNoRowInserted = 0; //No row added error
        public static int errorNoRowDeleted = 0; //No row deleted error
    }
}
