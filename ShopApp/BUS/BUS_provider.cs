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
    public class BUS_provider
    {
        public static DataTable load()
        {
            return DAO_provider.load();
        }
        public static DataTable search(string address = "", string country = "", string id = "", string name = "", string phone = "")
        {
            address = "%" + address + "%";
            country = "%" + country + "%";
            id = "%" + id + "%";
            name = "%" + name + "%";
            phone = "%" + phone + "%";
            if(DAO_provider.kiemtratontai(address, country, id, name, phone))
            {
                 return DAO_provider.search(address, country, id, name, phone);
            }
            return DAO_provider.load();
        }

        public static bool add(DTO_provider pr)
        {
            string a = "";
            int b = DAO_provider.demProvider();
            b += 1;
            if (b < 10)
                a = "00" + b.ToString();
            else if (b < 100)
                a = "0" + b.ToString();
            else
                a = b.ToString();
            pr.provID = "PR" + a;
            return DAO_provider.add(pr);
        }
        public static bool edit(DTO_provider pr)
        {
            return DAO_provider.edit(pr);
        }
        public static bool del(string id)
        {
            return DAO_provider.del(id);
        }
    }
}
