using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double shippingCost = customer.IsInUSA() ? 5.00 : 35.00;
        double productTotal = 0;

        foreach (var product in products)
        {
            productTotal += product.TotalCost();
        }

        return productTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += product.GetProductInfo() + "\n";
        }
        return label.Trim();
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += $"Customer Name: {customer.GetName()}\n";
        label += customer.GetAddress().GetFullAddress();
        return label.Trim();
    }
}
