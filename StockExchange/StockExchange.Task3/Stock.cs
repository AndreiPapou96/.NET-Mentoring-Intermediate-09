namespace StockExchange.Task3
{
    public class Stock
    {
        public IPlayer Owner { get; internal set; }
        public int Shares { get; internal set; }
        public Operation Operation { get; internal set; }
        public string Name { get; internal set; }
    }

    public enum Operation
    {
        Buy,
        Sell
    }
}