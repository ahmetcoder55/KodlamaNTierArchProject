using System.ComponentModel.DataAnnotations;
using KodlamaNTierProject.Entities.Abstract;

namespace KodlamaNTierProject.Entities.Concrete
{
    public class Product:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }

        // Navigation Property (Her ürünün bir kategorisi vardır)
        public Category? Category { get; set; }
    }
}