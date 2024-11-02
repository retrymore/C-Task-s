namespace OOPPractice;

//parent class with main parametrs
public class Purchase
{
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public Purchase()
    {
        ProductName = "Empty";
        Price = 0.0m;
        Quantity = 0;
    }
    public Purchase(string productName, decimal price, int quantity)
    {
        ProductName = productName;
        Quantity = quantity;
        Price = price;
    }
    //
    public virtual decimal GetCost()
    {
        return Price * Quantity;
    }
    public override string ToString()
    {
        return $"{ProductName}, {Price}, {Quantity}";
    }
    public override bool Equals(object? obj)
    {
        if (obj is Purchase other)
        {
            return this.ProductName == other.ProductName && this.Price == other.Price;
        }
        return false;
    }
}
