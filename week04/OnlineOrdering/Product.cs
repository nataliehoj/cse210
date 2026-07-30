using System;

public class Product
{
    private string ProdName;
    private string ProdID;
    private string ProdPrice;

    public Product(string _ProdName, string _ProdID, string _ProdPrice)
    {
        ProdName = _ProdName;
        ProdID = _ProdID;
        ProdPrice = _ProdPrice;
    }
    public string GetProdName()
    {
        return ProdName;
    }

    public string GetProdID()
    {
        return ProdID;
    }

    public string GetProdPrice()
    {
        return ProdPrice;
    }

}