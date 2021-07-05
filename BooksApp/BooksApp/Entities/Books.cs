using BooksApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Entities
{
    public class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }
        public string UnitPrice  { get; set; }

    }
}
