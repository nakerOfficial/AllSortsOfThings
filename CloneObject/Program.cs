using CloneObject;

Person person = new Person
{
    Age = 16,
    Name = "Vologia",
    Address = new Address
    {
        City = "Moscow",
        Street = "Lenin"
    }
};

Person person2 = (Person)person.Clone(); // Cloning 

person2.Name = "Uasia";
person2.Age = 18;
person2.Address = new Address
{
    City = "Chisinau",
    Street = "Lenin"
};

Console.WriteLine("=======================================");
Console.WriteLine(
    $"Name: {person.Name}"
    + $"\nAge: {person.Age}"
    + $"\nAddresss City: {person.Address.City}"
    + $"\nAddresss Street: {person.Address.Street}"
    );
Console.WriteLine();
Console.WriteLine();





