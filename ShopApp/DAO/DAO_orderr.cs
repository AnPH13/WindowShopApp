using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace DAO
{
    public class DAO_orderr
    {
        public static bool nhapOrderr(DTO_orderr od)
        {
            string query = "insert into ORDERR(ordID, ordDate, ordDescription, ordBill, cliID, staID, ordStatus)" +
                " values(@ordID, getdate(), @ordDescription, @ordBill, @cliID, @staID, @ordStatus)";
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ordID", od.ordID);
            param[1] = new SqlParameter("@ordDescription", od.ordDescription);
            param[2] = new SqlParameter("@ordBill", od.ordBill);
            param[3] = new SqlParameter("@cliID", od.cliID);
            param[4] = new SqlParameter("@staID", od.staID);
            param[5] = new SqlParameter("@ordStatus", od.ordStatus);
            return DataProvider.ExecuteNonQuery(query, param) > 0;
        }

        public static int demOrderr()
        {
            string query = "select count(*) from ORDERR";
            SqlParameter[] param = new SqlParameter[0];
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]);
        }
    }
}
