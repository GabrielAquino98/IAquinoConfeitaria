namespace IAquinoConfeitaria.Models
{
    public class BuyModel
    {
        public BuyModel(string supplierName, string description, decimal price, List<ItenBuyModel> itens)
        {
            Id = new Guid();
            SupplierName = supplierName;
            Description = description;
            Price = price;
            Itens = itens;
        }

        public BuyModel() { }

        public Guid Id { get; init; }
        public string SupplierName { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public List<ItenBuyModel> Itens { get; set; }
    }
}
