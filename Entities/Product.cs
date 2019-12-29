using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Product            
    {

        public int Id { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public double ProductPrice { get; set; }

        public string ProductImage { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public int CategoryId { get; set; }


    }
}
