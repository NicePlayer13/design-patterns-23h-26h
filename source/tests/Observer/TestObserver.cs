using DesignPatterns.Observer;

namespace DesignPatterns.Observer.Tests
{
    public class TestObserver : IObserver
    {
        public bool WasNotified { get; private set; }

        public void Update(Cart cart)
        {
            WasNotified = true;
        }
    }
}
