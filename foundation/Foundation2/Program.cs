using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address("street", "city", "state", "South Africa");
        Customer customer1 = new Customer("customer 1", address1);
        Console.WriteLine(customer1.DisplayAll());


        List<string> customer1Products = ["Hat", "Shoes", "Shirt", "Jeans"];
        List<int> customer1ProductsID = [1, 2, 3, 4];
        List<double> customer1ProductsCost = [9.99, 8.99, 13.99, 12.99];
        List<int> customer1ProductsQuantity = [2, 1, 4, 2];
        List<string> products1 = new List<string>();
        double totalcost = 0;

        for (int i = 0; i < customer1Products.Count; i++)
        {
            Product product1 = new Product(customer1Products[i], customer1ProductsID[i], customer1ProductsCost[i], customer1ProductsQuantity[i]);
            totalcost = totalcost + product1.GetTotalCost();
            products1.Add(product1.DisplayAll());
        }

  
        Order order = new Order(products1, customer1, address1);
        string packingLabel = order.DisplayPackingLabel();
        string shippingLabel = order.DisplayShippingLabel();
        Console.WriteLine(packingLabel);
        Console.WriteLine(shippingLabel);

        totalcost = totalcost + order.CalculateTotalCost();
        Console.WriteLine($"Total Cost: ${totalcost}");


       
        Address address2 = new Address("street", "city", "state", "Kenya");
        Customer customer2 = new Customer("customer 2", address2);
        Console.WriteLine(customer2.DisplayAll());

        List<string> customer2Products = ["Cake", "Juice", "Plates", "Cups"];
        List<int> customer2ProductsID = [5, 6, 7, 8];
        List<double> customer2ProductsCost = [5.99, 8.99, 19.99, 10.99];
        List<int> customer2ProductsQuantity = [3, 8, 20, 20];
        List<string> products2 = new List<string>();
        double totalcost2 = 0;

        for (int i = 0; i < customer2Products.Count; i++)
        {
            Product product2 = new Product(customer2Products[i], customer2ProductsID[i], customer2ProductsCost[i], customer2ProductsQuantity[i]);
            totalcost2 = totalcost2 + product2.GetTotalCost();
            products2.Add(product2.DisplayAll());
        }


        Order order2 = new Order(products2, customer2, address2);
        string packingLabel2 = order2.DisplayPackingLabel();
        string shippingLabel2 = order2.DisplayShippingLabel();
        Console.WriteLine(packingLabel2);
        Console.WriteLine(shippingLabel2);

        totalcost2 = totalcost2 + order2.CalculateTotalCost();
        Console.WriteLine($"Total Cost: ${totalcost2}");
    }
}