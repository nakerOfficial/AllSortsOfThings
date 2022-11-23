using DelegatesAndEvents;

namespace Delegates.Exeple_1_BankExangeMonitor
{
    public class Exemple1: IExemple
    {
        private StockExcangeMonitor stockExcangeMonitor;

        public Exemple1()
        {
            stockExcangeMonitor = new StockExcangeMonitor();
            stockExcangeMonitor.PriceChangeHandler = ShowPrice;
            stockExcangeMonitor.PriceChangeHandler += ShowPriceTwo;
        }

        public void Run()
        {
            stockExcangeMonitor.Start();
        }

        public void ShowPrice(int price)
        {
            Console.WriteLine($"Event 1: {price}");
        }

        public void ShowPriceTwo(int price)
        {
            Console.WriteLine($"Event 2: {price + 1}");
        }
    }
}
