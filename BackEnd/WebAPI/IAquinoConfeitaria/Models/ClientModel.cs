namespace IAquinoConfeitaria.Models
{
    public class ClientModel
    {
        public ClientModel(string name, string telefone, string cpf, DateTime birthDay)
        {
            Id = Guid.NewGuid();
            Name = name;
            Telefone = telefone;
            CPF = cpf;
            BirthDay = birthDay;
            Fidelity = 0;
        }

        ClientModel()
        {
        }

        public Guid Id { get; init; }
        public string Name { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public DateTime BirthDay { get; set; }

        public int Fidelity { get; init; }

    }
}
