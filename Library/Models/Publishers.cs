using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Publishers
    {
        public int? id { get; set; }
        public string name { get; set; }
        public string mailing_address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public int maximum_books { get; set; }
    }
}
