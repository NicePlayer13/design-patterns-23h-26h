using System;

namespace DesignPatterns.Observer
{
    public class InventoryChecker : IObserver
    {
        public void Update(Cart cart)
        {
            Console.WriteLine("📦 Lagerprüfung für Artikel im Warenkorb...");
            foreach (var item in cart.GetItems())
            {
                Console.WriteLine($"  - Verfügbarkeit prüfen: {item}");
            }
        } 
    }
}
