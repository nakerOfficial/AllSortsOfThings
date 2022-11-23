using _FreeTesting_ForExperiments;
using System.Text.Json;

TimeConvertor timeConvertor = new TimeConvertor("3:05 PM");
Console.WriteLine(timeConvertor.ConvertFrom12To24HoursFormat());

var oTest = new[]
{
    new
    {
        QuestionId = 1,
        AnswerId = 2
    },
    new
    {
        QuestionId = 3,
        AnswerId = 4
    }
};

string jsonString = JsonSerializer.Serialize(oTest);


foreach (var a in oTest)
{
    Console.WriteLine(a.AnswerId.ToString() + " - " + a.QuestionId.ToString());
}

Console.WriteLine(jsonString);
System.String[] tes = { "sdfsdf", "rtergfg" };
string[] testStrArr = { "sdfsdf", "rtergfg" };

Console.WriteLine(testStrArr.Count() + " / " + tes.Length);