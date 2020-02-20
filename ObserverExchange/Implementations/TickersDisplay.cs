using ObserverExchange.Interfaces;
using ObserverExchange.Models;
using System.Collections.Generic;

namespace ObserverExchange.Implementations
{
    public class TickersDisplay : IObserver, IDisplay
    {
        public void Display()
        {
            throw new System.NotImplementedException();
        }

        public void Update(ExchangeData exchangeData, AnalyticsData analiticsData, List<News> news)
        {
            throw new System.NotImplementedException();
        }
    }
}
