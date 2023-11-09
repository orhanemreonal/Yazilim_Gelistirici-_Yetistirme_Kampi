using _07_OOP2;

//Customer customer1 = new Customer();
//customer1.Name = "Orhan";
//customer1.Surname = "Onal";
//customer1.Identity = "22222222222";
//customer1.CustomerNo = "12345";
//customer1.CompanyName = "?";

// Gerçek Müşteri - Tüzel Müşteri
// SOLID

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.CustomerNo = "12345";
customer1.Name = "Orhan";
customer1.Surname = "Onal";
customer1.Identity = "41044444444";

CorporateCustomer customer2 = new CorporateCustomer();
customer2.Id = 2;
customer2.CustomerNo = "12345";
customer2.CompanyName = "Istanbul Kodluyor";
customer2.TaxNo = "41044444444";

Customer customer3 = new IndividualCustomer();
Customer customer4 = new CorporateCustomer();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);
customerManager.Add(customer3);
customerManager.Add(customer4);