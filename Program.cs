
Console.WriteLine("Hello, world!");
Console.WriteLine("My name is Marcus, and this is a test.");

Order order = new Order(2003, "Marcus Dingus", 300.00);

order.ApplyDiscount(25);
order.PrintSummary();

class Order
{
    public int Id { get; }
    public string CustomerName { get; }
    public double Total { get; private set; }

    public Order(int id, string customerName, double total)
    {
        Id = id;
        CustomerName = customerName;
        Total = total;
    }

    public void ApplyDiscount(double percent)
    {
        Total -= Total * (percent / 100.0);
    }

    public void PrintSummary()
    {
        Console.WriteLine($"Order {Id} for {CustomerName}: {Total:C}");
    }
}