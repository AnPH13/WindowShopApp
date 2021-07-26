using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_information_order
    {
        public string infoOrderID { get; set; }
        public string ordID { get; set; }
        public string prodID { get; set; }
        public int infoOrderSL { get; set; }
        public int infoOrderPrice { get; set; }
        public bool infoStatus { get; set; }
    }
}
