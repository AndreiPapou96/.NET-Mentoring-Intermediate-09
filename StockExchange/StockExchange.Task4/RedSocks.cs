﻿using System;

namespace StockExchange.Task4
{
    public class RedSocks : IPlayer
    {
        public int SoldShares { get; private set; }

        public int BoughtShares { get; private set; }

        public RedSocks()
        {

        }

        public bool SellOffer(string stockName, int numberOfShares)
        {
            StockMarket.StockOperationComplete += Update;
            return StockMarket.SellStock(stockName, this, numberOfShares);
        }

        public bool BuyOffer(string stockName, int numberOfShares)
        {
            StockMarket.StockOperationComplete += Update;
            return StockMarket.BuyStock(stockName, this, numberOfShares);
        }

        public void Update(object sender, Stock stock)
        {
            if (stock.Owner == this)
            {
                if (stock.Operation == Operation.Buy)
                {
                    BoughtShares += stock.Shares;
                }

                if (stock.Operation == Operation.Sell)
                {
                    SoldShares += stock.Shares;
                }
            }
            else
            {
                if (stock.Operation == Operation.Buy)
                {
                    SoldShares += stock.Shares;
                }

                if (stock.Operation == Operation.Sell)
                {
                    BoughtShares += stock.Shares;
                }
            }
        }
    }
}
