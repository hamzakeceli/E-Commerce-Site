using DALL.Database;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class CategoryManagement
    {
        private ProjectContext database;

        public CategoryManagement()
        {
            database = new ProjectContext();
        }

        public List<Category> GetCategories()
        {
            var categories = database.Category.ToList();
            return categories;
        }

    }




}
