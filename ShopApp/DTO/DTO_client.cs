using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_client
    {
        public string cliID { get; set; }
        public string cliName { get; set; }
        public string cliAddress { get; set; }
        public string cliCountry { get; set; }
        public string cliPostOfficeCode { get; set; }
        public string cliPhone { get; set; }
        public bool cliStatus { get; set; }
    }
}
