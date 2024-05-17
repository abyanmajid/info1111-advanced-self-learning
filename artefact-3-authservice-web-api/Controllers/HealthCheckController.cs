using Microsoft.AspNetCore.Mvc;

namespace AuthService.Controllers
{
    [ApiController]
    public class HealthCheckController: ControllerBase
    {
        [HttpGet("/")]
        public IActionResult HealthCheck()
        {
            return Ok("Hello World!\n");
        }
    }
}
