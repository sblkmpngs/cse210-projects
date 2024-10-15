using System;


public class Product

{

    private string _productName;
    private int _productId;
    private double _productCost;
    private int _quantity;

    public Product(string productName, int productID, double productCost, int quantity)
    {
        _productName = productName;
        _productId = productID;
        _productCost = productCost;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
    
        return _productCost * _quantity;
    }


    public string DisplayAll()
    {
        string product = @$"Item: {_productName} - Product ID: {_productId} - ${_productCost} - x {_quantity}";
        return product;
    }


}