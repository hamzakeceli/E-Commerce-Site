using DALL;
using Entities;
using System.Collections.Generic;

namespace Services
{
    public class ProductServices
    {

        private ProductManagement productManagement;

        public ProductServices()
        {
            productManagement = new ProductManagement();
        }

        public List<Product> GetProducts() => productManagement.GetProducts();


    }
}
