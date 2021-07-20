using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchange.Task4
{
    public interface IPlayer
    {
        int SoldShares { get; }

        int BoughtShares { get; }

        void Update(object sender, Stock stock);
    }
}
