using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eticaret.UI.Models
{
    public class ProductListViewModel
    {
        public ProductListViewModel()
        {
            Products = new List<Product>();
            Categories = new List<Category>();
        }

        public List<Product> Products { get; set; }

        public List<Category> Categories { get; set; }
    }
}