namespace Generics
{
    internal class Exemple_3
    {
        private readonly string _title = "Exemle 3, List";

        public void Run()
        {
            MyList<int> listInt = new MyList<int>();
            listInt.Add(1);
            listInt.Add(3);
            listInt.Add(4);
            Console.WriteLine($"{_title}: {listInt.ToString()}");

            MyList<double> listDouble = new MyList<double>();
            listDouble.Add(1.45);
            listDouble.Add(3.234);
            listDouble.Add(4.5666);
            Console.WriteLine($"{_title}: {listDouble.ToString()}");

            MyList<string> listString = new MyList<string>();
            listString.Add("text-1");
            listString.Add("text-2");
            listString.Add("text-3");
            Console.WriteLine($"{_title}: {listString.ToString()}");

            MyList<bool> listBool = new MyList<bool>();
            listBool.Add(true);
            listBool.Add(false);
            listBool.Add(true);
            Console.WriteLine($"{_title}: {listBool.ToString()}");

            Console.WriteLine();
        }
    }

    public class MyList<T>
    {
        private T[] _array = Array.Empty<T>();

        public T this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }

        public void Add(T value)
        {
            var newArray = new T[_array.Length + 1];

            for (int i = 0; i < _array.Length; i++) newArray[i] = _array[i];

            newArray[_array.Length] = value;
            _array = newArray;
        }

        public string ToString()
        {
            string result = string.Empty;
            string virgule = ", ";

            foreach (var item in _array) result += item.ToString() + virgule;

            return result.Remove(result.Length - virgule.Length);
        }
    }
}
