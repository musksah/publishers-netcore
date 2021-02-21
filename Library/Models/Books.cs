using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Books
    {
        public int? id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string genre { get; set; }
        public int number_pages { get; set; }
        public int id_publisher { get; set; }
        public int id_autor { get; set; }
    }
}
