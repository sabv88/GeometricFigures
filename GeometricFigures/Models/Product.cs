
namespace GeometricFigures.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public List<Category> Categories { get; set; } = new();
    }
}
