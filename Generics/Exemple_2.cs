namespace Generics
{
    internal class Exemple_2
    {
        private readonly string _title = "Exemle 2, Method with retutn value";

        public void Run()
        {
            int resultInt = Foo<int>();
            Console.WriteLine($"{_title}: {resultInt}");

            double resultDouble = Foo<double>();
            Console.WriteLine($"{_title}: {resultDouble}");

            bool resultBool = Foo<bool>();
            Console.WriteLine($"{_title}: {resultBool}");

            string resultString = Foo<string>();
            Console.WriteLine($"{_title}: {resultString}");

            Console.WriteLine();
        }

        private T Foo<T>()
        {
            return default(T);
        }
    }
}
