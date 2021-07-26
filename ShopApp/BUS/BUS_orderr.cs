using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_orderr
    {
        public static bool nhapOrder(DTO_orderr od, DTO_information_order io)
        {
            string a = "";
            int b = DAO_orderr.demOrderr();
            b += 1;
            if (b < 10)
                a = "00" + b.ToString();
            else if (b < 100)
                a = "0" + b.ToString();
            else
                a = b.ToString();
            od.ordID = "OD" + a;
            od.ordStatus = true;
            od.ordBill = "OB" + a;
            io.infoOrderID = "IO" + a;
            io.ordID = od.ordID;
            io.infoStatus = true;
            return (DAO_orderr.nhapOrderr(od) && DAO_information_order.nhapInformation_order(io));
        }
    }
}
