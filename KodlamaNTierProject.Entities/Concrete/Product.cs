using System.ComponentModel.DataAnnotations;

namespace KodlamaNTierProject.Entities.Concrete
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }

        // Navigation Property (Her ürünün bir kategorisi vardır)
        public Category Category { get; set; }
    }
}