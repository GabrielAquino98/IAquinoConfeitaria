namespace IAquinoConfeitaria.Models
{
    public class ProductModel
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public List<string> Ingredients { get; set; }
    }
}
