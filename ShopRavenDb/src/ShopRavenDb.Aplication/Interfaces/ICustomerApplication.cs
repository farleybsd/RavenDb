namespace ShopRavenDb.Aplication.Interfaces
{
    public interface ICustomerApplication
    {
        void AddCustomer(CustomerDto customer);
        void UpdateCustomer(CustomerDto customer);
        void DeleteCustomerById(string id);
        IEnumerable<CustomerDto> GetCustomers();
        CustomerDto GetCustomerById(string id);
    }
}
