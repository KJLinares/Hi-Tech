using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessUsersDB;

namespace UsersBussinessSide
{
    public class UserClass

    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public EmployeeClass EmployeeRec { get; set; }

        //Constructors
        public UserClass()
        {
            UserName = "";
            Password = "";
            EmployeeRec = new EmployeeClass();
        }

        public UserClass(string userName, string password, EmployeeClass employeeID)
        {
            UserName = userName;
            Password = password;
            EmployeeRec = employeeID;
        }

        //Methods asociated with the DataBase access 

        public UserClass SearchUser(int emplID)
        {
            return UsersDB.SearchRecordByID(emplID);
        }
        public UserClass SearchUser(string userName)
        {
            return UsersDB.SearchRecordByUserName(userName);
        }
        public bool UpdateUser(UserClass usr)
        {
            return UsersDB.UpdateRecordByID(usr);
        }
        public bool SaveUser(UserClass usr)
        {
            return UsersDB.SaveRecord(usr);
        }

        public bool DeleteUser(int emplID)
        {
            return UsersDB.DeleteRecordByID(emplID);
        }
        public List<UserClass> ListUsers()
        {
            return UsersDB.ListRecords();
        }

    }
}
