using System;

public class Order
{
    private List<Product> products = new List<Product>();
    private string PackLab;
    private string ShipLab;
    private List<Customer> customers = new List<Customer>();

    public Order(string _PackLab, string _ShipLab)
    {
        PackLab = _PackLab;
        ShipLab = _ShipLab;
    }

    public string GetPackLab()
    {
        return PackLab;
    }

    public string GetShipLab()
    {
        return ShipLab;
    }

    
}