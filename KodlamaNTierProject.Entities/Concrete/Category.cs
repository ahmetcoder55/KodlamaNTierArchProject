using System.ComponentModel.DataAnnotations;

namespace KodlamaNTierProject.Entities.Concrete
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation Property (Bir kategorinin birden fazla ürünü olabilir)
        public ICollection<Product> Products { get; set; }
    }
}