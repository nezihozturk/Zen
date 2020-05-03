using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zen.Entities.Concrete;

namespace Zen.Mvc.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }

        //public int ProductId { get; set; }
        //public string ProductName { get; set; }
        //public  string CategoryName { get; set; }
        //public int  UnitsInStock { get; set; }
    }
}
