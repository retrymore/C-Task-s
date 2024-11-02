namespace OOPPractice;

//class with fixed sale
public class FixedSales : Purchase
{
    private decimal discount { get; set; }
    public FixedSales(string productName, decimal price, int quantity, decimal discount)
        : base(productName, price, quantity)
    {
        this.discount = discount;
    }
    public override decimal GetCost()
    {
        return base.GetCost() - discount;
    }
    public override string ToString()
    {
        return $"{base.ToString()}, discounted price";
    }
}
