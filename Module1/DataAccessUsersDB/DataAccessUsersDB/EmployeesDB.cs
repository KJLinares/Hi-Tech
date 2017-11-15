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
    public static class EmployeesDB
    {
        //Method that search an existing employee by the ID and returns the found employee
        public static EmployeeClass SearchRecordByID(int employeeID)
        {
            EmployeeClass emp = new EmployeeClass();

            string sqlSelect = "SELECT * FROM Employees " +
                               "WHERE EmployeeID = " + employeeID;

            //connect the database
            SqlConnection sqlConn = UtilityDB.ConnectDB();
            //Customize the SqlCommand object
            SqlCommand sqlCmd = new SqlCommand(sqlSelect, sqlConn);
            //Use SqlDataReader object to stored data returned
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            if (sqlReader.Read())
            {
                emp.EmployeeID = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();


            }
            else
            {
                emp = null;
            }

            sqlConn.Close();
            return emp;

        }

        //Method that updates information of an employeee based on the ID and returns true if suceedes the update
        public static bool UpdateRecordByID(EmployeeClass empl)
        {
            bool success = false;
            
                string sqlUpdate = "UPDATE Employees " +
                                "SET FirstName = '" + empl.FirstName + "' , LastName = '" + empl.LastName + "' , JobTitle = '" + empl.JobTitle +"' "
                               + "WHERE EmployeeID = " + empl.EmployeeID;

                //connect the database
                SqlConnection sqlConn = UtilityDB.ConnectDB();
                //Customize the SqlCommand object
                SqlCommand sqlCmd = new SqlCommand(sqlUpdate, sqlConn);
                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                success = true;
                     

            return success;
        }

        //Method that saves a new employee on the record and returns true if suceedes the saving
        public static bool SaveRecord(EmployeeClass empl)
        {
            bool success = false;

            
                string sqlInsert = "INSERT INTO Employees ( FirstName , LastName , JobTitle ) " +
                                    "VALUES ( '" +  empl.FirstName + "','" +
                                                empl.LastName + "' , '" + empl.JobTitle + "' )";

                //connect the database
                SqlConnection sqlConn = UtilityDB.ConnectDB();
                //Customize the SqlCommand object
                SqlCommand sqlCmd = new SqlCommand(sqlInsert, sqlConn);
                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                success = true;
             

            return success;
        }

        //Method that deletes an employeee based on the ID and returns true if suceedes the deleting 
        public static bool DeleteRecordByID(int employeeID)
        {
            bool success = false;

            try
            {
                string sqlDelete = "DELETE FROM Employees " +
                                    "WHERE EmployeeID = " + employeeID;

                SqlConnection sqlConn = UtilityDB.ConnectDB();
                SqlCommand sqlCmd = new SqlCommand(sqlDelete,sqlConn);
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

        //Method that lists information of all employees on the DataBase
        public static List<EmployeeClass> ListRecords()
        {
            List<EmployeeClass> listEmployees = new List<EmployeeClass>();

            string sqlSelect = "SELECT * FROM Employees ";

            SqlConnection sqlConn = UtilityDB.ConnectDB();
            SqlCommand sqlCmd = new SqlCommand(sqlSelect,sqlConn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                EmployeeClass emp = new EmployeeClass();

                emp.EmployeeID = Convert.ToInt32(sqlReader["EmployeeID"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();

                listEmployees.Add(emp);

            }

            sqlConn.Close();

            return listEmployees;
        }
    }
}
