public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double GetTotal()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }

        total += _customer.LiveInUsa() ? 5 : 35;
        return total;
    }
    public string GetPackageLabel()
    {
        string label = "packing List:\n";
        foreach (var product in _products)
        {
            label += ($"{product.GetProductName()} {product.GetProductId()}\n");
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return ($"Shipping Label:\n{_customer.GetShippingLabel()}");
    }
}