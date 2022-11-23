namespace StructVsClass
{
    internal class ClassPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.WriteLine($"X:{X} \t Y:{Y}");
        }
    }
}
