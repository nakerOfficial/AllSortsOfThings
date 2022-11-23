namespace _FreeTesting_ForExperiments
{
    internal class TimeConvertor
    {
        private string _time;

        public TimeConvertor(string time)
        {
            _time = time;
        }

        public string ConvertFrom12To24HoursFormat()
        {
            return DateTime.Parse(_time).ToString("HH:mm");
        }
    }
}
