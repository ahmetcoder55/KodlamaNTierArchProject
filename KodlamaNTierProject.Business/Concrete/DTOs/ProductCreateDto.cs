using System.ComponentModel.DataAnnotations;

namespace KodlamaNTierProject.Business.Concrete.DTOs
{
    public record ProductCreateDto
    {
        [Required(ErrorMessage = "Ürün adı boş geçilemez.")]
        [StringLength(100, ErrorMessage = "Ürün adı en fazla 100 karakter olabilir.")]
        public string Name { get; init; } = string.Empty;

        [Range(0.01, double.MaxValue, ErrorMessage = "Fiyat 0'dan büyük olmalıdır.")]
        public decimal Price { get; init; }

        [Range(0, int.MaxValue, ErrorMessage = "Stok miktarı negatif olamaz.")]
        public int Stock { get; init; }

        [Required(ErrorMessage = "Bir kategori seçilmelidir.")]
        public int CategoryId { get; init; }
    }
}