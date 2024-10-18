public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product (string name, string productId, double price, int quantity)
    {
        _name = name;
        _productID = productId;
        _price = price;
        _quantity = quantity;
    }
    public string GetProductName()
    {
        return _name;
    }
    public string GetProductId()
    {
        return _productID;
    }
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
    public string Display()
    {
        return($"{_name} {_productID}, Quantity: {_quantity}, Price: {_price}");
    }
}