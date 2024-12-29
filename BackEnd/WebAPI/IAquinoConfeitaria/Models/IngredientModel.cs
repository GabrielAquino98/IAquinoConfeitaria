namespace IAquinoConfeitaria.Models
{
    public class IngredientModel
    {
        public IngredientModel(string name, string description, string price, decimal qttUsedPerProduct, decimal qttInStock)
        {
            Id = new Guid();
            Name = name;
            Description = description;
            Price = price;
            QttUsedPerProduct = qttUsedPerProduct;
            QttInStock = qttInStock;
        }

        public IngredientModel() { }

        public Guid Id { get; init; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public decimal QttUsedPerProduct { get; set; }
        public decimal QttInStock { get; set; }
    }
}
