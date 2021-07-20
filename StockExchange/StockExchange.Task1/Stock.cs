using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchange.Task1
{
    public class Stock
    {
        public string Name { get; set; }
        public Player Owner { get; set; }
        public Operation Operation { get; set; }
        public int Shares { get; set; }
    }

    public enum Operation
    {
        Sell,
        Buy
    }
}