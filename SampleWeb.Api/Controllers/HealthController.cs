using Microsoft.AspNetCore.Mvc;

namespace SampleWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("App is in good health");
        }
    }
}