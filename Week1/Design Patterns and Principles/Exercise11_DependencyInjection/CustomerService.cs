public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}

public interface ICustomerRepository
{
    Customer? FindCustomerById(int id);
}

public class CustomerRepositoryImpl : ICustomerRepository
{
    private readonly List<Customer> _customers = new()
    {
        new Customer { Id = 1, Name = "Alice" },
        new Customer { Id = 2, Name = "Bob" },
    };

    public Customer? FindCustomerById(int id) =>
        _customers.FirstOrDefault(c => c.Id == id);
}

public class CustomerService
{
    private readonly ICustomerRepository _repository;
    public CustomerService(ICustomerRepository repository) => _repository = repository;

    public void PrintCustomer(int id)
    {
        var customer = _repository.FindCustomerById(id);
        Console.WriteLine(customer != null
            ? $"Found: ID={customer.Id}, Name={customer.Name}"
            : $"Customer with ID {id} not found.");
    }
}
