using ClassMetotDemoo;

CustomerManager customerManager = new CustomerManager();

Customer customer1 = new Customer();
customer1.Id = 123;
customer1.FirstName = "Alper";
customer1.LastName = "Harika";

Customer customer2 = new Customer();
customer2.Id = 456;
customer2.FirstName = "Cansu";
customer2.LastName = "Ezik";

customerManager.Add(customer1);
customerManager.Add(customer2);
customerManager.List();
customerManager.Delete(customer2);
customerManager.List();