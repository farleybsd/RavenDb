using ShopRavenDb.Domain.Model;

namespace ShopRavenDb.Aplication.Dtos
{
    public class CustomerDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public Address Address { get; set; }
        public string Cpf { get; set; }
    }
}
