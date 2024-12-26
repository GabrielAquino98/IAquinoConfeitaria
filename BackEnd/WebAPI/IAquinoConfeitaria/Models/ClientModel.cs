namespace IAquinoConfeitaria.Models
{
    public class ClientModel
    {
        public ClientModel(string name, string telefone, string cpf, DateTime birthDay, int fidelity)
        {
            Id = Guid.NewGuid();
            Name = name;
            Telefone = telefone;
            CPF = cpf;
            BirthDay = birthDay;
            Fidelity = fidelity;
        }

        public Guid Id { get; init; }
        public string Name { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public DateTime BirthDay { get; set; }

        public int Fidelity { get; set; }

    }
}
