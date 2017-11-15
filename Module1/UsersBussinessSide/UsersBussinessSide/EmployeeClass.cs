using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessUsersDB;

namespace UsersBussinessSide
{
    public class EmployeeClass
    {

        public int EmployeeID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string JobTitle { get; set; }

        // constructors
        public EmployeeClass()
        {
            EmployeeID = 0;
            FirstName = "";
            LastName = "";
            JobTitle = "";
        }

        public EmployeeClass(int employeeID, string firstName, string lastName, string jobTitle)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            JobTitle = jobTitle;
        }

        //methods connected to the database 
        public EmployeeClass SearchEmployee(int emplID)
        {
            return EmployeesDB.SearchRecordByID(emplID);
        }
        public bool UpdateEmployee(EmployeeClass empl)
        {
            return EmployeesDB.UpdateRecordByID(empl);
        }
        public bool SaveEmployee(EmployeeClass empl)
        {
            return EmployeesDB.SaveRecord(empl);
        }
        public bool DeleteEmployee(int empl)
        {
            return EmployeesDB.DeleteRecordByID(empl);
        }
        public List<EmployeeClass> ListEmployees()
        {
            return EmployeesDB.ListRecords();
        }

    }
}
