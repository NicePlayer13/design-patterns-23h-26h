using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public class Cart : ISubject
    {
        private readonly List<IObserver> _observers = new();
        private readonly List<string> _items = new();

        public void AddItem(string item)
        {
            _items.Add(item);
            Console.WriteLine($"Produkt hinzugefügt: {item}");
            NotifyObservers();
        }

        public void RemoveItem(string item)
        {
            _items.Remove(item);
            Console.WriteLine($"Produkt entfernt: {item}");
            NotifyObservers();
        }

        public List<string> GetItems() => new(_items);

        public void RegisterObserver(IObserver observer) => _observers.Add(observer);
        public void RemoveObserver(IObserver observer) => _observers.Remove(observer);
        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
