namespace IAquinoConfeitaria.Models
{
    public class OrderModel
    {
        public Guid Id { get; init; }
        public int Number { get; set; }
        public int MyProperty { get; set; }
        public ClientModel Client { get; set; }

    }
}
