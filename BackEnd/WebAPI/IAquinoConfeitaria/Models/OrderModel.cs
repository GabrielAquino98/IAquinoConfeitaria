using IAquinoConfeitaria.Models.Enum;

namespace IAquinoConfeitaria.Models
{
    public class OrderModel
    {
        public OrderModel(int number, List<ProductModel> products, ClientModel client, 
                            DateTime deliveryDate, DateTime orderDate, bool paid, 
                            decimal totalValue, decimal valueReceived, DateTime dateReceived, 
                            CouponModel? coupon, decimal? priceOff, AddressModel? address, 
                            OrderStatus status)
        {
            Id = new Guid();
            Number = number;
            Products = products;
            Client = client;
            DeliveryDate = deliveryDate;
            OrderDate = orderDate;
            Paid = paid;
            TotalValue = totalValue;
            ValueReceived = valueReceived;
            DateReceived = dateReceived;
            Coupon = coupon;
            PriceOff = priceOff;
            Address = address;
            Status = status;
        }

        public OrderModel() { }

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
