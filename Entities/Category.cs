﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category
    {

        public Category()
        {
            Products = new List<Product>(); //POCO HATASI    
        }

        public int Id { get; set; }

        public string CategoryName { get; set; }

        public List<Product> Products { get; set; }

    }
}