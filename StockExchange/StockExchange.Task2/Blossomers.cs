using System;

namespace StockExchange.Task2
{
    public class Blossomers
    {
        private string ID;
        public Blossomers()
        {
            ID = Guid.NewGuid().ToString();
        }

        public bool SellOffer(string stockName, int numberOfShares)
        {
            return StockMarket.SellStock(stockName, ID, numberOfShares);
        }

        public bool BuyOffer(string stockName, int numberOfShares)
        {
            return StockMarket.BuyStock(stockName, ID, numberOfShares);
        }
    }
}
