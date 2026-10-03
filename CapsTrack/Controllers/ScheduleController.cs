
using CapsTrack.api.Services;
using Microsoft.AspNetCore.Mvc;

namespace CapsTrack.api.Controllers
{
    [ApiController]
    [Route("api/team/schedule")]
    public class GetScheduleController : ControllerBase
    {
        private readonly IScheduleService _scheduleService;

        public GetScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            // Use _scheduleService here to return real data.
            return Ok();
        }
    }
}
