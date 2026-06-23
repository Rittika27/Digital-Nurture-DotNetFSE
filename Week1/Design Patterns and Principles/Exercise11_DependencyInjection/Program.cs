ICustomerRepository repo = new CustomerRepositoryImpl();
CustomerService service = new(repo);

service.PrintCustomer(1);
service.PrintCustomer(2);
service.PrintCustomer(99);
