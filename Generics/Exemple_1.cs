namespace Generics
{
    internal class Exemple_1
    {
        private readonly string _title = "Exemle 1, Method void";

        public void Run()
        {
            int valueInt1 = 7, valueInt2 = 9;
            Swap<int>(ref valueInt1, ref valueInt2);
            Console.WriteLine($"{_title}: a={valueInt1}, b={valueInt2}");

            double valueDouble1 = 68.45, valueDouble2 = 23.09;
            Swap<double>(ref valueDouble1, ref valueDouble2);
            Console.WriteLine($"{_title}: a={valueDouble1}, b={valueDouble2}");

            string valueString1 = "val 1", valueString2 = "val 2";
            Swap<string>(ref valueString1, ref valueString2);
            Console.WriteLine($"{_title}: a={valueString1}, b={valueString2}");

            Console.WriteLine();
        }

        private void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
