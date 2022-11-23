using GlobalExceptionHandling.Database.Entities;

namespace GlobalExceptionHandling.Services
{
    public interface IStaffRepository
    {
        public IEnumerable<Employee> GetAllEmployees();
        public Employee LoadRoberto ();
    }
}
