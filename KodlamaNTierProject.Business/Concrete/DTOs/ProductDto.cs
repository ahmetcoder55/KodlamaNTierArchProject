namespace KodlamaNTierProject.Business.Concrete.DTOs
{
    public record ProductDto
    {
        
       public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public decimal Price { get; init; }
        public int Stock { get; init; }
        
        // Kategori ID'si yerine direkt ismini dönerek kolaylık sağlıyoruz
        public int CategoryId { get; init; }
        public string? CategoryName { get; init; } 
    }
}