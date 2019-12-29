using Entities;
using System.Data.Entity.ModelConfiguration;

namespace DALL.Mapping
{
    public class ProductMapping : EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            ToTable("Products", "eCommerce");
        }

    }
}
