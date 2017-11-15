using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersBussinessSide;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccessUsersDB
{
    public static class UsersDB
    {
        //Method that search an existing User account by the ID of the employee and returns the found employee
        public static UserClass SearchRecordByID(int employeeID)
        {
            UserClass user = new UserClass();

            string sqlSelect = "SELECT * FROM Users " +
                               "WHERE EmployeeID = " + employeeID;

            //connect the database
            SqlConnection sqlConn = UtilityDB.ConnectDB();
            //Customize the SqlCommand object
            SqlCommand sqlCmd = new SqlCommand(sqlSelect, sqlConn);
            //Use SqlDataReader object to stored data returned
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            if (sqlReader.Read())
            {
                user.EmployeeRec.EmployeeID = Convert.ToInt32(sqlReader["EmployeeId"]);
                user.UserName = sqlReader["UserName"].ToString();
                user.Password = sqlReader["Password"].ToString();
            }
            else
            {
                user = null;
            }

            sqlConn.Close();
            return user;

        }

        //Overload method of search now by User name
        public static UserClass SearchRecordByUserName(string userName)
        {
            UserClass user = new UserClass();

            string sqlSelect = "SELECT * FROM Users " +
                               "WHERE UserName = '" + Convert.ToString(userName)+ "'";
            

            //connect the database
            SqlConnection sqlConn = UtilityDB.ConnectDB();
            //Customize the SqlCommand object
            SqlCommand sqlCmd = new SqlCommand(sqlSelect, sqlConn);
            //Use SqlDataReader object to stored data returned
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            if (sqlReader.Read())
            {
                user.EmployeeRec.EmployeeID = Convert.ToInt32(sqlReader["EmployeeId"]); 
                user.UserName = sqlReader["UserName"].ToString();
                user.Password = sqlReader["Password"].ToString();
            }
            else
            {
                user = null;
            }

            sqlConn.Close();
            return user;

        }

        //Method that updates information of an user account based on the employee ID and returns true if suceedes the update
        public static bool UpdateRecordByID(UserClass usr)
        {
            bool success = false;

            try
            {
                string sqlUpdate = "UPDATE Users " +
                                "SET UserName = '" + usr.UserName + "' , Password = '" + usr.Password + "' "
                               + "WHERE EmployeeID = " + Convert.ToInt32(usr.EmployeeRec.EmployeeID);

                //connect the database
                SqlConnection sqlConn = UtilityDB.ConnectDB();
                //Customize the SqlCommand object
                SqlCommand sqlCmd = new SqlCommand(sqlUpdate, sqlConn);
                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                success = true;
            }
            catch (SqlException exceSQL)
            {

                throw exceSQL;
            }


            return success;
        }

        //Method that saves a new user acc on the record and returns true if suceedes the saving
        public static bool SaveRecord(UserClass usr)
        {
            bool success = false;

            try
            {
                string sqlInsert = "INSERT INTO Users ( UserName , Password , EmployeeID ) " +
                                    "VALUES ( '" + usr.UserName + "' , '" + usr.Password + "' , " +
                                                usr.EmployeeRec.EmployeeID  + " )";

                //connect the database
                SqlConnection sqlConn = UtilityDB.ConnectDB();
                //Customize the SqlCommand object
                SqlCommand sqlCmd = new SqlCommand(sqlInsert, sqlConn);
                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                success = true;
            }
            catch (SqlException exceSql)
            {

                throw exceSql;
            }

            return success;
        }

        //Method that deletes an user account based on the employee ID and returns true if suceedes the deleting 
        public static bool DeleteRecordByID(int employeeID)
        {
            bool success = false;

            try
            {
                string sqlDelete = "DELETE FROM Users " +
                                    "WHERE EmployeeID = " + employeeID;

                SqlConnection sqlConn = UtilityDB.ConnectDB();
                SqlCommand sqlCmd = new SqlCommand(sqlDelete, sqlConn);
                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                success = true;
            }
            catch (SqlException exceSql)
            {

                throw exceSql;
            }
            return success;


        }

        //Method that lists information of all Users on the DataBase
        public static List<UserClass> ListRecords()
        {
            List<UserClass> listUsers = new List<UserClass>();

            string sqlSelect = "SELECT * FROM Users ";

            SqlConnection sqlConn = UtilityDB.ConnectDB();
            SqlCommand sqlCmd = new SqlCommand(sqlSelect, sqlConn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                UserClass usr = new UserClass();

                usr.EmployeeRec.EmployeeID = Convert.ToInt32(sqlReader["EmployeeID"]);
                usr.UserName = sqlReader["UserName"].ToString();
                usr.Password = sqlReader["Password"].ToString();

                listUsers.Add(usr);

            }

            sqlConn.Close();

            return listUsers;
        }
        
    }
}
