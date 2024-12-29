using IAquinoConfeitaria.Models.Enum;

namespace IAquinoConfeitaria.Models
{
    public class OrderModel
    {
        public Guid Id { get; init; }
        public int Number { get; set; }
        public required List<ProductModel> Products { get; set; }
        public required ClientModel Client { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Paid { get; set; }
        public decimal TotalValue { get; set; }
        public decimal ValueReceived { get; set; }
        public DateTime DateReceived { get; set; }
        public CouponModel? Coupon { get; set; }
        public decimal? PriceOff { get; set; }
        public AddressModel? Address { get; set; }
        public OrderStatus Status { get; set; }
    }
}
