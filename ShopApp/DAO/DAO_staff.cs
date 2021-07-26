using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DAO_staff
    {
        public static string getName(string id)
        {
            string query = "SELECT staName FROM STAFF WHERE LoginID = @id";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", id);
            return DataProvider.ExecuteSelectQuery(query, param).Rows[0][0].ToString();
        }
        public static string getVT(string id)
        {
            string query = "SELECT staPosition FROM STAFF WHERE LoginID = @id";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", id);
            return DataProvider.ExecuteSelectQuery(query, param).Rows[0][0].ToString();
        }
        public static DataTable getDSNV()
        {
            string query = "SELECT * FROM STAFF";
            SqlParameter[] param = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, param);
        }
        public static bool checkSearch(bool status, string name, string address, string id, string sdt)
        {
            string query = "select count(*) from STAFF where staStatus = @status and staName like @name and staID like @id and staAddress like @address and staPhone like @sdt";
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@status", status);
            param[1] = new SqlParameter("@name", name);
            param[2] = new SqlParameter("@id", id);
            param[3] = new SqlParameter("@address", address);
            param[4] = new SqlParameter("@sdt", sdt);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) > 0;
        }
        public static DataTable Search(bool status, string name, string address, string id, string sdt)
        {
            string query = "select * from STAFF where staStatus = @status and staName like @name and staID like @id and staAddress like @address and staPhone like @sdt";
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@status", status);
            param[1] = new SqlParameter("@name", name);
            param[2] = new SqlParameter("@id", id);
            param[3] = new SqlParameter("@address", address);
            param[4] = new SqlParameter("@sdt", sdt);
            return DataProvider.ExecuteSelectQuery(query, param);
        }

        public static string getSDT(string id)
        {
            string query = "SELECT staPhone FROM STAFF WHERE LoginID = @id";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", id);
            return DataProvider.ExecuteSelectQuery(query, param).Rows[0][0].ToString();
        }
    }
}
