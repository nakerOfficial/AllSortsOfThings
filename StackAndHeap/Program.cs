using StackAndHeap;


#region Referentiality
{
    var apples = new Basket();
    apples.ItemsCount = 5;

    var oranges = apples;
    oranges.ItemsCount += 20;

    Console.WriteLine(apples.ItemsCount);
}
#endregion


#region Structure in Steck
{
    void Process(ref MyStructure myStructure)
    {
        myStructure.Apples = 3;
        myStructure.Bananas = 4;
        myStructure.Oranges = 2;
    }

    MyStructure myStructure = new MyStructure();
    Process(ref myStructure);

    Console.WriteLine($"{myStructure.Apples} - {myStructure.Bananas} - {myStructure.Oranges}");
}
#endregion

