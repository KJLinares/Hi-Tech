using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;
using UsersBussinessSide;
using System.Configuration;




namespace DataAccessUsersDB
{
    public class UtilityDB
    {
        /// <summary>
        /// This method connects and open the database
        /// </summary>
        public static SqlConnection ConnectDB()
        {
            SqlConnection conn = new SqlConnection();
            
           
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["UsersEmployeesConnectionstring"].ConnectionString;

            conn.Open();
            return conn;

        }
    }
}
