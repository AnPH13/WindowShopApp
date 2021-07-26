using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_provider
    {
        public string provID { get; set; }
        public string provFullName { get; set; }
        public string provName { get; set; }
        public string provAddress { get; set; }
        public string provPostOfficeCode { get; set; }
        public string provCountry { get; set; }
        public string provPhone { get; set; }
        public string provDescription { get; set; }
        public bool status { get; set; }
    }
}
