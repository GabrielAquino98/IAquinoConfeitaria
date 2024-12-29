namespace IAquinoConfeitaria.Models
{
    public class CouponModel
    {
        public CouponModel(string code, string description, string priceOff, ClientModel client, DateTime validityData)
        {
            Id = new Guid();
            Code = code;
            Description = description;
            PriceOff = priceOff;
            Client = client;
            ValidityData = validityData;
        }

        public CouponModel() { }

        public Guid Id { get; init; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string PriceOff { get; set; }
        public ClientModel Client { get; set; }
        public DateTime ValidityData { get; set; }
    }
}
