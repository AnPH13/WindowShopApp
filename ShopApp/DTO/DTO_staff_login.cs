using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_staff_login
    {
        public string LoginID { get; set; }
        public string LoginUserName { get; set; }
        public string LoginPassword { get; set; }
        public bool LoginStatus { get; set; }
    }
}
