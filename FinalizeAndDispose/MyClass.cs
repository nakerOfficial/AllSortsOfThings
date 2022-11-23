namespace FinalizeAndDispose
{
    internal class MyClass: IDisposable
    {
        static int counter = 0;

        public MyClass ()
        {
            Console.WriteLine($"constructor of MyClass - {++counter}");
        }

        public void MyMethod()
        {
            Console.WriteLine($"method of MyClass - {counter}");
        }

        public void Dispose()
        {
            Console.WriteLine($"Dispose - {counter}");
        }

        ~MyClass()
        {
            Console.WriteLine($"destructor of MyClass - {counter} \n");
        }
    }
}
