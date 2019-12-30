using DALL.Database;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DALL
{
    public class ProductManagement
    {
        private ProjectContext database;

        public ProductManagement()
        {
            database = new ProjectContext();
        }

        public List<Product> GetProducts()
        {
            //  var products = database.Product.ToList();  sadece product getirir
             var products = database.Product.Include("Category").ToList();

            //var products = database.Product
            //                              .Include(i=>i.Category)
            //                               .ToList();


            return products;
        }

    }




}
