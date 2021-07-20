using System.Collections.Generic;

namespace StockExchange.Task2
{
    public class StockMarket
    {
        public static List<Stock> stocks = new List<Stock>();

        public static bool BuyStock(string name, string buyerID, int numberOfShares)
        {
            var stock = stocks.Find(stock => stock.Name == name
                && stock.Operation == Operation.Sell
                && stock.OwnerId != buyerID
                && stock.Shares == numberOfShares);

            if (stock != null)
            {
                stocks.Remove(stock);

                return true;
            }
            else
            {
                AddStock(name, buyerID, Operation.Buy, numberOfShares);

                return false;
            }
        }

        public static bool SellStock(string name, string sellerId, int numberOfShares)
        {
            var stock = stocks.Find(stock => stock.Name == name
                && stock.Operation == Operation.Buy
                && stock.OwnerId != sellerId
                && stock.Shares == numberOfShares);

            if (stock != null)
            {
                stocks.Remove(stock);

                return true;
            }
            else
            {
                AddStock(name, sellerId, Operation.Sell, numberOfShares);

                return false;
            }
        }

        private static void AddStock(string name, string playerId, Operation operation, int numberOfShares)
        {
            stocks.Add(new Stock
            {
                Name = name,
                OwnerId = playerId,
                Operation = operation,
                Shares = numberOfShares
            });
        }
    }
}