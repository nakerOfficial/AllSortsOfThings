using ExtensionMethod;
using ExtensionMethodStudent;

DateTime dateTime = DateTime.Now;

Console.Write("ex1: ");
dateTime.Print();

Console.Write("ex2: ");
DateTime.Now.Print();

Console.WriteLine($"ex3: Is day of week: {dateTime.IsDayOfWeek(DayOfWeek.Saturday)}");

Student student = new Student
{
    FirstName = "Iurii",
    LastName = "Rosca"
};
Console.WriteLine($"ex4: Student's full name: {student.FullName()}");
