using DALL.Mapping;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Database
{
    public class ProjectContext:DbContext
    {



        public ProjectContext()
           : base("defaultConnection")  //wepconfig alıyor
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
             modelBuilder.Configurations.Add(new CategoryMapping());
             modelBuilder.Configurations.Add(new ProductMapping());

            //s takısı olmadan tablo yarat
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Category> MyProperty { get; set; }

        public DbSet<Product> Product { get; set; }










    }
}
