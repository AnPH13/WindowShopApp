using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DAO_Product
    {
        public static DataTable getDSSP()
        {
            string query = "SELECT * FROM PRODUCT";
            SqlParameter[] param = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, param);
        }

        public static DataTable Search(string a, string b)
        {
            string query = "select * from PRODUCT where " + a + " like @b";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@b", b);
            return DataProvider.ExecuteSelectQuery(query, param);
        }

        public static DataTable getSearch(string name, string price, string id, string memory, string year)
        {
            string query = "select * from PRODUCT where prodName like @name and prodPrice like @price and prodID like @id and prodMenory like @memory and prodReleaseYear like @year";
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@name", name);
            param[1] = new SqlParameter("@price", price);
            param[2] = new SqlParameter("@id", id);
            param[3] = new SqlParameter("@memory", memory);
            param[4] = new SqlParameter("@year", year);
            return DataProvider.ExecuteSelectQuery(query, param);
        }

        public static bool kiemtratontai(string name, string price, string id, string memory, string year) 
        {
            string query = "select count(*) from PRODUCT where prodName like @name and prodPrice like @price and prodID like @id and prodMenory like @memory and prodReleaseYear like @year";
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@name", name);
            param[1] = new SqlParameter("@price", price);
            param[2] = new SqlParameter("@id", id);
            param[3] = new SqlParameter("@memory", memory);
            param[4] = new SqlParameter("@year", year);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) > 0;
        }
    }
}
