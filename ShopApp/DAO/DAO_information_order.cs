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
    public class DAO_information_order
    {
        public static bool nhapInformation_order(DTO_information_order io)
        {
            string query = "insert into INFORMATION_ORDER(infoOrderID, ordID, prodID, infoOrderSL, infoOrderPrice, infoStatus)" +
                " values(@infoOrderID, @ordID, @prodID, @infoOrderSL, @infoOrderPrice, @infoStatus)";
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@infoOrderID", io.infoOrderID);
            param[1] = new SqlParameter("@ordID", io.ordID);
            param[2] = new SqlParameter("@prodID", io.prodID);
            param[3] = new SqlParameter("@infoOrderSL", io.infoOrderSL);
            param[4] = new SqlParameter("@infoOrderPrice", io.infoOrderPrice);
            param[5] = new SqlParameter("@infoStatus", io.infoStatus);
            return DataProvider.ExecuteNonQuery(query, param) > 0;
        }
    }
}
