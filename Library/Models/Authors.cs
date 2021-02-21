using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Authors
    {
        public int? id { get; set; }
        public string name { get; set; }
        public DateTime birthday { get; set; }
        public string born_city { get; set; }
        public string email { get; set; }
    }
}
