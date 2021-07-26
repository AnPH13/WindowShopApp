using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;


namespace BUS
{
    public class BUS_staff
    {
        public static string getName(string id)
        {
            return DAO_staff.getName(id);
        }
        public static string getVT(string id)
        {
            return DAO_staff.getVT(id);
        }

        public static DataTable getDSNV()
        {
            return DAO_staff.getDSNV();
        }

        public static string getSDT(string id) 
        {
            return DAO_staff.getSDT(id);
        }

        public static DataTable search(bool status, string name = "", string address = "", string id = "", string sdt = "")
        {
            name = "%" + name + "%";
            address = "%" + address + "%";
            id = "%" + id + "%";
            sdt = "%" + sdt + "%";
            if (DAO_staff.checkSearch(status, name, address, id, sdt))
            {
                return DAO_staff.Search(status, name, address, id, sdt);
            }
            return DAO_staff.getDSNV();
        }
    }
}
