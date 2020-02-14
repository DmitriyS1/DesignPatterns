namespace ObserverExchange.Interfaces
{
    /// <summary>
    /// Интерфейс субъекта
    /// </summary>
    interface ISubject
    {
        /// <summary>
        /// Зарегистрировать наблюдателя
        /// </summary>
        /// <param name="observer">Объект наблюдателя</param>
        void RegisterObserver(IObserver observer);

        /// <summary>
        /// Удалить наблюдателя
        /// </summary>
        /// <param name="observer">Объект наблюдателя</param>
        void RemoveObserver(IObserver observer);

        /// <summary>
        /// Уведомить наблюдателей
        /// </summary>
        void NotifyObservers();
    }
}
