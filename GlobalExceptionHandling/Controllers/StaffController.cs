using GlobalExceptionHandling.Services;
using Microsoft.AspNetCore.Mvc;

namespace GlobalExceptionHandling.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StaffController: ControllerBase
    {
        private readonly ILogger<StaffController> _logger;
        private readonly IStaffRepository _istaffRepository;

        public StaffController(ILogger<StaffController> logger, IStaffRepository istaffRepository)
        {
            _logger = logger;
            _istaffRepository = istaffRepository;
        }

        [HttpGet("employees")]
        public IActionResult GetAllEmployees()
        {
            var employees = _istaffRepository.GetAllEmployees();

            return Ok(employees);
        }

        [HttpGet("roberto")]
        public IActionResult GetRoberto()
        {
            var roberto = _istaffRepository.LoadRoberto();

            return Ok(roberto);
        }

    }
}
