using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchange.Task1
{
    public class StockMarket
    {
        public static List<Stock> stocks = new List<Stock>();

        public static bool BuyStock(string name, Player buyer, int numberOfShares)
        {
            var stock = stocks.Find(stock => stock.Name == name
                && stock.Operation == Operation.Sell
                && stock.Owner != buyer
                && stock.Shares == numberOfShares);

            if (stock != null)
            {
                stocks.Remove(stock);

                return true;
            } else
            {
                AddStock(name, buyer, Operation.Buy, numberOfShares);

                return false;
            }
        }

        public static bool SellStock(string name, Player seller, int numberOfShares)
        {
            var stock = stocks.Find(stock => stock.Name == name 
                && stock.Operation == Operation.Buy
                && stock.Owner != seller
                && stock.Shares == numberOfShares);

            if (stock != null)
            {
                stocks.Remove(stock);

                return true;
            } else
            {
                AddStock(name, seller, Operation.Sell, numberOfShares);

                return false;
            }
        }

        private static void AddStock(string name, Player player, Operation operation, int numberOfShares)
        {
            stocks.Add(new Stock
            {
                Name = name,
                Owner = player,
                Operation = operation,
                Shares = numberOfShares
            });
        }

    }
}
