namespace OOPPractice;

//in dev
public class QuantitySale : Purchase
{
    private int minimumQuantity { get; set; }
    private decimal discount { get; set; }
    public QuantitySale(string productName, decimal price, int quantity, int minimumQuantity, decimal discount)
        : base(productName, price, quantity)
    {
        this.minimumQuantity = minimumQuantity;
        this.discount = discount;
    }
    public override decimal GetCost()
    {
        return Quantity >= minimumQuantity ? base.GetCost() - discount : base.GetCost();
    }
    public override string ToString()
    {
        return $"{base.ToString()}, Quantity discount";
    }
}
