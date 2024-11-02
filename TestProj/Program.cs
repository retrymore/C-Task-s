namespace OOPPractice;

public class Program
{
    static void Main()
    {
        Purchase[] purchases = new Purchase[]
        {
            new Purchase("Item 1", 100, 1),
            new Purchase("Item 2", 200, 3),
            new FixedSales("Item 3", 300, 2, 50),
            new FixedSales("Item 4", 150, 1, 30),
            new QuantitySale("Item 5", 250, 5, 3, 50),
            new QuantitySale("Item 6", 180, 2, 3, 20)
        };
        decimal maxCost = 0;
        Purchase maxPurchase = null;
        bool areAllEqual = true;
        for (int i = 0; i < purchases.Length; i++)
        {
            Console.WriteLine(purchases[i]);
            decimal currentCost = purchases[i].GetCost();
            if (currentCost > maxCost)
            {
                maxCost = currentCost;
                maxPurchase = purchases[i];
            }
            if (i > 0 && !purchases[i].Equals(purchases[i]))
            {
                areAllEqual = false;
            }
        }
        Console.WriteLine($"Max purchase: {maxPurchase}");
        Console.WriteLine($"All purchases are equal: {(areAllEqual ? "Yes":"No")}");
    }
}