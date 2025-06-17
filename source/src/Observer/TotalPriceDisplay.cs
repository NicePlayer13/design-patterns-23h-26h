using System;

namespace DesignPatterns.Observer
{
    public class TotalPriceDisplay : IObserver
    {
        public void Update(Cart cart)
        {
            Console.WriteLine($"🛒 Anzahl Artikel im Warenkorb: {cart.GetItems().Count}");
        }
    }
}
