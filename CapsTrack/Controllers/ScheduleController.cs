
using CapsTrack.api.Services;
using Microsoft.AspNetCore.Mvc;

namespace CapsTrack.api.Controllers
{
    [ApiController]
    [Route("api/capitals/schedule")]
    public class GetScheduleController : ControllerBase
    {
        private readonly IScheduleService _scheduleService;

        public GetScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(
            CancellationToken cancellationToken)
        {
            var schedule = await _scheduleService.GetTeamScheduleAsync(
                "WSH",
                "20262027",
                cancellationToken);
            return Ok(schedule);
        }
    }
}
