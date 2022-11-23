namespace ExtensionMethod
{
    internal static class MyExtensions
    {
        public static void Print(this DateTime dateTime)
        {
            Console.WriteLine($"Test extencion: {dateTime}");
        }

        public static bool IsDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            return dateTime.DayOfWeek == dayOfWeek;
        }
    }
}
