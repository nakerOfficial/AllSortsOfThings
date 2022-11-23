using GlobalExceptionHandling.Database.Entities;

namespace GlobalExceptionHandling.Database
{
    public static class Context
    {
        public static List<Employee> Employees = new List<Employee>
        {
            new Employee{ Id = 1, Name = "Ivan", Salary = 1500 },
            new Employee{ Id = 2, Name = "Boris", Salary = 500 },
            new Employee{ Id = 2, Name = "Roberto", Salary = 10000 },
        };
    }
}
