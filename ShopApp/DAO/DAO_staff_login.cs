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
    public class DAO_staff_login
    {
        public static bool kiemtratontai(string user)
        {
            string query = "select count(*) from STAFF_LOGIN where LoginUserName = @LoginUserName";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@LoginUserName", user);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) == 1;
        }

        public static string KiemTraMatKhau(string Username)
        {
            string query = "select LoginPassword from STAFF_LOGIN where LoginUserName = @Username";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Username", Username);
            return DataProvider.ExecuteSelectQuery(query, param).Rows[0][0].ToString();
        }
        public static string getName(string id)
        {
            string query = "select LoginUserName from STAFF_LOGIN where LoginID = @id";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", id);
            return DataProvider.ExecuteSelectQuery(query, param).Rows[0][0].ToString();
        }

        public static string LayID(string Username)
        {
            string query = "select LoginID from STAFF_LOGIN where LoginUserName = @Username";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Username", Username);
            return DataProvider.ExecuteSelectQuery(query, param).Rows[0][0].ToString();
        }

        public static bool update(string usercu, string usermoi, string pass)
        {
            string query = "update STAFF_LOGIN set LoginUserName = @usermoi, LoginPassword = @pass where LoginUserName = @usercu";
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@usermoi", usermoi);
            param[1] = new SqlParameter("@pass", pass);
            param[2] = new SqlParameter("@usercu", usercu);
            return DataProvider.ExecuteNonQuery(query, param) > 0;
        }
    }
}
