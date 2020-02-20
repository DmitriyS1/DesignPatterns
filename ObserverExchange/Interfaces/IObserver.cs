using ObserverExchange.Models;
using System.Collections.Generic;

namespace ObserverExchange.Interfaces
{
    /// <summary>
    /// Интерфейс для наблюдателя
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Обновить информацию
        /// </summary>
        void Update(ExchangeData exchangeData, AnalyticsData analiticsData, List<News> news);
    }
}
