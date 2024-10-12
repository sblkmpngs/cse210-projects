using System;


public class Order

{
    private List<string> _products;

    private string _nameCustomer;

    private double _shippingUS;

    private double _shippingWorldwide;

    public Order(List<string> products, string nameCustomer, double shippingUS, double shippingWorldwide)
    {
        _products = products;
        _nameCustomer = nameCustomer;
        _shippingUS = shippingUS;
        _shippingWorldwide = shippingWorldwide;

    }



    public void AddProduct(Product product)
    {

    }

    public double CalculateTotalCost()
    {
        

        return 0;
    }

    public string DisplayPackingLabel()
    {
        
        return "";
    }

    public string DisplayShippingLabel()
    {
       
        return "";
    }


}