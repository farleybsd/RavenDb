﻿namespace ShopRavenDb.Domain.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public Address Address { get; set; }
        public string Cpf { get; set; }
    }
}
