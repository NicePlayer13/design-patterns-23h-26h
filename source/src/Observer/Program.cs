using System;

namespace DesignPatterns.Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cart = new Cart();

            var totalPriceDisplay = new TotalPriceDisplay();
            var inventoryChecker = new InventoryChecker();

            cart.RegisterObserver(totalPriceDisplay);
            cart.RegisterObserver(inventoryChecker);

            cart.AddItem("Laptop");
            cart.AddItem("Kopfhörer");
            cart.RemoveItem("Laptop");

            Console.ReadLine();
        }
    }
}
