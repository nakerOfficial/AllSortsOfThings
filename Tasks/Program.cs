// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void DoWork()
{
    Console.WriteLine("Task1: Start simple Tasks");
};

Task.Factory.StartNew(() => Console.WriteLine("Task0: Start Task Factory"));
var task1 = new Task(DoWork);
var task2 = new Task(delegate { Console.WriteLine("Task2: Start delegate Tasks"); });
var task3 = new Task<int>(() => (int)new Random().Next());
var task4 = new Task<int>(x => (int)x, 45);

# region Cancel Task
var cts = new CancellationTokenSource();
var token = cts.Token;
var task5 = new Task(() =>
{
    for (int i = 0; i < int.MaxValue; i++)
    {
        token.ThrowIfCancellationRequested();
        Console.Write(".");
    }
}, token);

var task6 = new Task(() =>
{
    token.WaitHandle.WaitOne();
    Console.WriteLine("Tasks 5 and 7 were cancel but it started task 6");
});

var task7 = new Task(() =>
{
    for (int i = 0; i < int.MaxValue; i++)
    {
        if (token.IsCancellationRequested)
        {
            Console.WriteLine("canceled :" + i);
            throw new OperationCanceledException(token);
        }
        else
        {
            Console.Write("-");
        }
    }
}, token);
#endregion


#region Start Tasks
task6.Start();
task7.Start();
task5.Start();

//Task.WaitAll(task7, task5);

task1.Start();
task2.Start();

task3.Start();
Console.WriteLine("Task3: Task with result: " + task3.Result);

task4.Start();
Console.WriteLine("Task4: Task with result: " + task4.Result);

Thread.Sleep(500);
cts.Cancel();
#endregion

token.Register(() =>
{
    Console.WriteLine($"Token cancel delegate Register called: Task5={task5.IsCanceled}, Task7={task7.IsCanceled}");
});
