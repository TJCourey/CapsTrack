using Microsoft.AspNetCore.Mvc;

namespace CapsTrack.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthCheck : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                Status = "Healthy",
                Timestamp = DateTime.UtcNow
            });
        }
    }
}
