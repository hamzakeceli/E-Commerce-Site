using DALL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryServices
    {

        private CategoryManagement categoryManagement;

        public CategoryServices()
        {
            categoryManagement = new CategoryManagement();
        }

        public List<Category> GetCategories() => categoryManagement.GetCategories();

       
    }
}
