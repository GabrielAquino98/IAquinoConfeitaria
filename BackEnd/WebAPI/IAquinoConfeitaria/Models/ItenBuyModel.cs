namespace IAquinoConfeitaria.Models
{
    public class ItenBuyModel
    {
        public ItenBuyModel(string description, decimal price, decimal quantity)
        {
            Id = new Guid();
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        public ItenBuyModel() { }

        public Guid Id { get; init; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
}
