namespace Delegates.Exeple_1_BankExangeMonitor
{
    public class StockExcangeMonitor
    {
        public delegate void PriceChange(int price);

        public PriceChange PriceChangeHandler { get; set; }


        public void Start()
        {
            while (true)
            {
                int banckOfAmericaPrice = new Random().Next(100);

                PriceChangeHandler(banckOfAmericaPrice);

                Thread.Sleep(1000);
            }
        }

    }
}
