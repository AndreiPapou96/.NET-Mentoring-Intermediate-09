namespace StockExchange.Task2
{
    public class Stock
    {
        public string Name { get; set; }
        public string OwnerId { get; set; }
        public Operation Operation { get; set; }
        public int Shares { get; set; }
    }

    public enum Operation
    {
        Sell,
        Buy
    }
}