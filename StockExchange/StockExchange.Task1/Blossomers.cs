using System;

namespace StockExchange.Task1
{
    public class Blossomers: Player
    {
        public Blossomers() 
        { 
        }

        public bool SellOffer(string stockName, int numberOfShares)
        {
            return StockMarket.SellStock(stockName, this, numberOfShares);
        }

        public bool BuyOffer(string stockName, int numberOfShares)
        {
            return StockMarket.BuyStock(stockName, this, numberOfShares);
        }
    }
}
