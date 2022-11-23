using GlobalExceptionHandling.Database;
using GlobalExceptionHandling.Database.Entities;

namespace GlobalExceptionHandling.Services
{
    public class StaffRepository : IStaffRepository
    {
        public IEnumerable<Employee> GetAllEmployees()
        {
            throw new Exception("Some strange exception here!");

            return Context.Employees;
        }

        public Employee LoadRoberto()
        {
            throw new KeyNotFoundException("Roberto! Where are you?");

            return Context.Employees.FirstOrDefault(a => a.Name == "Roberto");
        }
    }
}
