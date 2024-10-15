using System;


public class Customer

{
    private string _customerName;

    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool Location()
    {

        bool custLocation = _address.Location();
        return custLocation;
    }

    public string DisplayAll()
    {
        return _customerName;

    }



}