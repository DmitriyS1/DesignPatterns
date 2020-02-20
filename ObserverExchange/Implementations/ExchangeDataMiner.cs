using ObserverExchange.Interfaces;
using ObserverExchange.Models;
using System.Collections.Generic;

namespace ObserverExchange.Implementations
{
    public class ExchangeDataMiner : ISubject
    {
        private List<IObserver> Observers;
        private ExchangeData Data;
        private AnalyticsData Analitics;
        private List<News> News;

        public ExchangeDataMiner()
        {
            Observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach(var observer in Observers) 
            {
                observer.Update(Data, Analitics, News);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            var index = Observers.FindIndex(c => c == observer);
            Observers.RemoveAt(index);
        }

        public void SetData(ExchangeData exchangeData, AnalyticsData analiticsData, List<News> news)
        {
            Data = exchangeData;
            Analitics = analiticsData;
            News = news;

            NotifyObservers();
        }
    }
}
