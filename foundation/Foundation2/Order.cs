using System;


public class Order

{
    private List<string> _products;
    private Customer _nameCustomer;
    private Address _address;
    private int _shippingcost;

    public Order(List<string> products, Customer nameCustomer, Address address)
    {
        _products = products;
        _nameCustomer = nameCustomer;
        _address = address;

    }



    public void AddProduct()
    {

    }

    public double CalculateTotalCost()
    {
        int totalcost = 0;


    
        bool orderAddress = _address.Location();
        if (orderAddress == true)
        {
            _shippingcost = 5;
            totalcost = totalcost + _shippingcost;
        }
        else
        {
            _shippingcost = 35;
            totalcost = totalcost + _shippingcost;
        }

        return totalcost;
    }

    public string DisplayPackingLabel()
    {
        string packingLabel = "";
     
        foreach (var item in _products)
        {
            string label = item;
            packingLabel = packingLabel + label + "\n";
        }
        return packingLabel;
    }

    public string DisplayShippingLabel()
    {
 
        string shippingLabel = $"{_nameCustomer.DisplayAll()} {_address.DisplayAll()}";
        return shippingLabel;
    }


}