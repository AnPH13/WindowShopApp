using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_staff_login
    {
        public static bool KiemTraDangNhap(string user, string pass)
        {
            if (DAO_staff_login.kiemtratontai(user))
                return DAO_staff_login.KiemTraMatKhau(user) == pass;
            return false;
        }
        public static string getID(string user)
        {
            return DAO_staff_login.LayID(user);
        }

        public static string getName(string id)
        {
            return DAO_staff_login.getName(id);
        }

        public static bool kiemtratontai(string user)
        {
            return DAO_staff_login.kiemtratontai(user);
        }
        public static bool kiemtramatkhau(string user, string pass)
        {
            return DAO_staff_login.KiemTraMatKhau(user) == pass;
        }
        public static bool update(string usercu, string usermoi, string pass)
        {
            return DAO_staff_login.update(usercu, usermoi, pass);
        }
    }
}
