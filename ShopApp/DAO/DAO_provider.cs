using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_provider
    {
        public static DataTable load()
        {
            string query = "SELECT * FROM PROVIDED";
            SqlParameter[] param = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, param);
        }
        public static DataTable search(string address, string country, string id, string name, string phone)
        {
            string query = "select * from PROVIDED where provAddress like @address and provCountry like @country and provID like @id and provFullName like @name and provPhone = @phone";
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@address", address);
            param[1] = new SqlParameter("@country", country);
            param[2] = new SqlParameter("@id", id);
            param[3] = new SqlParameter("@name", name);
            param[4] = new SqlParameter("@phone", phone);
            return DataProvider.ExecuteSelectQuery(query, param);
        }
        public static bool kiemtratontai(string address, string country, string id, string name, string phone)
        {
            string query = "select count(*) from PROVIDED where provAddress like @address and provCountry like @country and provID like @id and provFullName like @name and provPhone = @phone";
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@address", address);
            param[1] = new SqlParameter("@country", country);
            param[2] = new SqlParameter("@id", id);
            param[3] = new SqlParameter("@name", name);
            param[4] = new SqlParameter("@phone", phone);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) > 0;
        }
        public static int demProvider()
        {
            string query = "select count(*) from PROVIDED";
            SqlParameter[] param = new SqlParameter[0];
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]);
        }
        public static bool add(DTO_provider pr)
        {
            string query = "insert into PROVIDED(provID, provFullName, provName, provAddress, provPostOfficeCode, provCountry, provPhone, provDescription, provStatus)" +
                " values(@provID, @provFullName, @provName, @provAddress, @provPostOfficeCode, @provCountry, @provPhone, @provDescription, @provStatus)";
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@provID", pr.provID);
            param[1] = new SqlParameter("@provFullName", pr.provFullName);
            param[2] = new SqlParameter("@provName", pr.provName);
            param[3] = new SqlParameter("@provAddress", pr.provAddress);
            param[4] = new SqlParameter("@provPostOfficeCode", pr.provPostOfficeCode);
            param[5] = new SqlParameter("@provCountry", pr.provCountry);
            param[6] = new SqlParameter("@provPhone", pr.provPhone);
            param[7] = new SqlParameter("@provDescription", pr.provDescription);
            param[8] = new SqlParameter("@provStatus", pr.status);
            return DataProvider.ExecuteNonQuery(query, param) > 0;
        }
        public static bool edit(DTO_provider pr)
        {
            string query = "update PROVIDED set provFullName = @provFullName," +
                " provName = @provName, provAddress = @provAddress, provPostOfficeCode = @provPostOfficeCode," +
                " provCountry = @provCountry, provPhone = @provPhone, provDescription = @provDescription, provStatus = @provStatus" +
                " where  provID = @provID";
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@provFullName", pr.provFullName);
            param[1] = new SqlParameter("@provName", pr.provName);
            param[2] = new SqlParameter("@provAddress", pr.provAddress);
            param[3] = new SqlParameter("@provPostOfficeCode", pr.provPostOfficeCode);
            param[4] = new SqlParameter("@provCountry", pr.provCountry);
            param[5] = new SqlParameter("@provPhone", pr.provPhone);
            param[6] = new SqlParameter("@provDescription", pr.provDescription);
            param[7] = new SqlParameter("@provStatus", pr.status);
            param[8] = new SqlParameter("@provID", pr.provID);
            return DataProvider.ExecuteNonQuery(query, param) > 0;
        }
        public static bool del(string id)
        {
            string query = "update PROVIDED set provStatus = 0 where provID = @provID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@provID", id);
            return DataProvider.ExecuteNonQuery(query, param) > 0;
        }
    }
}
