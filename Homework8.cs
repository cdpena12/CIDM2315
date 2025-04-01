namespace Homework8;

class Customer
{
    public string CustomerName { get; set; }
    public int CustomerAge { get; set; }
    public string CustomerCity { get; set; }
    public double CustomerCredit { get; set; }

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        CustomerName = customerName;
        CustomerAge = customerAge;
        CustomerCity = customerCity;
        CustomerCredit = customerCredit;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer("Alice", 33, "Amarillo", 198.5);
        Customer cus2 = new Customer("Bob", 23, "Amarillo", 226);
        Customer cus3 = new Customer("Cathy", 45, "Amarillo", 89.0);
        Customer cus4 = new Customer("David", 58, "Amarillo", 198.5);
        Customer cus5 = new Customer("Jack", 28, "Canyon", 561.6);
        Customer cus6 = new Customer("Tom", 36, "Canyon", 98.4);
        Customer cus7 = new Customer("Tony", 24, "Canyon", 18.5);
        Customer cus8 = new Customer("Sam", 35, "Canyon", 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

        CalculateTotalCredit(customer_list);
        CalculateAverageAgeAmarillo(customer_list);
        PrintCanyonCustomersAbove30(customer_list);
    }

    static void CalculateTotalCredit(Customer[] customers)
    {
        double totalCredit = customers.Sum(c => c.CustomerCredit);
        Console.WriteLine($"Total credit of all customers: {totalCredit}");
    }

    static void CalculateAverageAgeAmarillo(Customer[] customers)
    {
        var amarilloCustomers = customers.Where(c => c.CustomerCity == "Amarillo").ToList();
        if (amarilloCustomers.Count > 0)
        {
            double avgAge = amarilloCustomers.Average(c => c.CustomerAge);
            Console.WriteLine($"Average age of customers in Amarillo: {avgAge:F2}");
        }
        else
        {
            Console.WriteLine("No customers in Amarillo.");
        }
    }

    static void PrintCanyonCustomersAbove30(Customer[] customers)
    {
        var canyonCustomers = customers.Where(c => c.CustomerCity == "Canyon" && c.CustomerAge > 30);
        Console.WriteLine("Customers in Canyon older than 30:");
        foreach (var customer in canyonCustomers)
        {
            Console.WriteLine(customer.CustomerName);
        }
    }
}

