using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_orderr
    {
        public string ordID { get; set; }
        public string ordDate { get; set; }
        public string ordDescription { get; set; }
        public string ordBill { get; set; }
        public string cliID { get; set; }
        public string staID { get; set; }
        public bool ordStatus { get; set; }
    }
}
