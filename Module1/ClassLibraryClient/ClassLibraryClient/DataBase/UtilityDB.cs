using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ClassLibraryClient
{
    public static class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection con = new SqlConnection(GetConnectionstring());
            con.Open();
            return con;
              
        }

        private static string GetConnectionstring()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UsersEmployeesConnectionString"].ConnectionString;
            return connectionString;
        }
        public static SqlDataAdapter GetDataAdapter()
        {
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Clients", GetConnectionstring());
            return sqlDA;
        }

        public static DataSet GetDataSet(DataSet ds, DataTable dt)
        {
            SqlDataAdapter sqlDA = GetDataAdapter();

            sqlDA.FillSchema(ds, SchemaType.Source, "Clients");
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ClientID"] };
            sqlDA.Fill(ds, "Clients");

            return ds;
        }

    }
}
