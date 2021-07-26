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
    public class BUS_Product
    {
        public static DataTable getDSSP()
        {
            return DAO_Product.getDSSP();
        }
        public static DataTable search(int a, string b)
        {
            string a1 = "prodID";
            b = "%" + b + "%";
            switch (a)
            {
                case 0: a1 = "prodName"; break;
                case 2: a1 = "prodReleaseYear"; break;
                case 3: a1 = "prodRAM"; break;
            }
            return DAO_Product.Search(a1, b);
        }
        public static DataTable getSearch(string name = "", string price = "", string id = "", string memory = "", string year = "")
        {
            name = "%" + name + "%";
            price = "%" + price + "%";
            id = "%" + id + "%";
            memory = "%" + memory + "%";
            year = "%" + year + "%";
            if (DAO_Product.kiemtratontai(name, price, id, memory, year))
            {
                return DAO_Product.getSearch(name, price, id, memory, year);
            }
            return DAO_Product.getDSSP();
        }
    }
}
