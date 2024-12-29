using System.ComponentModel.DataAnnotations;

namespace IAquinoConfeitaria.Models
{
    public class AddressModel
    {
        public AddressModel() { }

        public AddressModel(string cep, string street, string number, string complement, string city)
        {
            Id = new Guid();
            CEP = cep;
            Street = street;
            Number = number;
            Complement = complement;
            City = city;
        }


        public Guid Id { get; init; }
        public string CEP { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string City { get; set; }
    }
}
