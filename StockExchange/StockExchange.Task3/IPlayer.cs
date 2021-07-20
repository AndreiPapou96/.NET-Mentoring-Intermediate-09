using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchange.Task3
{
    public interface IPlayer
    {
        int SoldShares { get; }

        int BoughtShares { get; }

        void Update(Stock stock);
    }
}
