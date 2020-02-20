using ObserverExchange.Interfaces;
using ObserverExchange.Models;
using System;
using System.Collections.Generic;

namespace ObserverExchange.Implementations
{
    public class AnalyticsDisplay : IObserver, IDisplay
    {
        private ExchangeData Data;
        private AnalyticsData Analitics;

        public void Display()
        {
            Console.WriteLine("Analytics evaluates here...");
        }

        public void Update(ExchangeData exchangeData, AnalyticsData analiticsData, List<News> news)
        {
            Data = exchangeData;
            Analitics = analiticsData;
            Display();
        }
    }
}
