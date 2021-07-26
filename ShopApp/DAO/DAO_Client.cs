using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class DAO_Client
    {
        public static DataTable getDSKH()
        {
            string query = "SELECT * FROM CLIENT";
            SqlParameter[] param = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, param);
        }
        public static DataTable Search(string a, string b)
        {
            string query = "select * from CLIENT where " + a + " like @b";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@b", b);
            return DataProvider.ExecuteSelectQuery(query, param);
        }
        public static int demClient()
        {
            string query = "select count(*) from CLIENT";
            SqlParameter[] param = new SqlParameter[0];
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]);
        }
        public static bool addClient(DTO_client cli)
        {
            string query = "insert into CLIENT(cliID, cliName, cliAddress, cliCountry, cliPostOfficeCode, cliPhone, cliStatus)" +
                " values(@cliID, @cliName, @cliAddress, @cliCountry, @cliPostOfficeCode, @cliPhone, @cliStatus)";
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@cliID", cli.cliID);
            param[1] = new SqlParameter("@cliName", cli.cliName);
            param[2] = new SqlParameter("@cliAddress", cli.cliAddress);
            param[3] = new SqlParameter("@cliCountry", cli.cliCountry);
            param[4] = new SqlParameter("@cliPostOfficeCode", cli.cliPostOfficeCode);
            param[5] = new SqlParameter("@cliPhone", cli.cliPhone);
            param[6] = new SqlParameter("@cliStatus", cli.cliStatus);
            return DataProvider.ExecuteNonQuery(query, param) > 0;
        }
        public static bool editClient(DTO_client cli)
        {
            string query = "update CLIENT set cliName = @cliName, cliAddress = @cliAddress, cliCountry = @cliCountry, cliPostOfficeCode = @cliPostOfficeCode, cliPhone = @cliPhone where cliID = @cliID";
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@cliName", cli.cliName);
            param[1] = new SqlParameter("@cliAddress", cli.cliAddress);
            param[2] = new SqlParameter("@cliCountry", cli.cliCountry);
            param[3] = new SqlParameter("@cliPostOfficeCode", cli.cliPostOfficeCode);
            param[4] = new SqlParameter("@cliPhone", cli.cliPhone);
            param[5] = new SqlParameter("@cliID", cli.cliID);
            return DataProvider.ExecuteNonQuery(query, param) > 0;
        }

        public static bool delClient(string id)
        {
            string query = "update CLIENT set cliStatus = 0 where cliID = @cliID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cliID", id);
            return DataProvider.ExecuteNonQuery(query, param) > 0;
        }
    }
}
