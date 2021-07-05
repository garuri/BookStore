using BooksApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Entities
{
    public class Discounts
    {
        public Genre Genre { get; set; }

        public decimal DiscountPercent { get; set; }

    }
}
