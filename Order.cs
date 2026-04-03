namespace HelloCSharp
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public double Total { get; set; }

        public Order(int orderId, string customerName, double total)
        {
            OrderId = orderId;
            CustomerName = customerName;
            Total = total;
        }

        public void ApplyDiscount(double percent)
        {
            Total -= Total * (percent / 100);
        }

        public void PrintSummary()
        {
            Console.WriteLine($"Order #{OrderId} for {CustomerName}: ${Total:F2}");
        }
    }
}