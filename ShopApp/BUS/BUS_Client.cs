using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_Client
    {
        public static DataTable getDSKH()
        {
            return DAO_Client.getDSKH();
        }
        public static DataTable search(int a, string b)
        {
            string a1 = "cliName";
            b = "%" + b + "%";
            switch (a)
            {
                case 0: a1 = "cliName"; break;
                case 1: a1 = "cliID"; break;
                case 2: a1 = "cliPhone"; break;
            }
            return DAO_Client.Search(a1, b);
        }
        public static bool addClient(DTO_client cli)
        {
            string a = "";
            int b = DAO_Client.demClient();
            b += 1;
            if (b < 10)
                a = "00" + b.ToString();
            else if (b < 100)
                a = "0" + b.ToString();
            else
                a = b.ToString();
            cli.cliID = "KH" + a;
            cli.cliStatus = true;
            return DAO_Client.addClient(cli);
        }
        public static bool editClient(DTO_client cli)
        {
            return DAO_Client.editClient(cli);
        }
        public static bool delClient(string id)
        {
            return DAO_Client.delClient(id);
        }
    }
}