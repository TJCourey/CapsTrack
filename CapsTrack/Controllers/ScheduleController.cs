
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
            try
            {
                var schedule = await _scheduleService.GetTeamScheduleAsync(
                    "WSH",
                    "20262027",
                    cancellationToken);
                return Ok(schedule);
            }
            catch (HttpRequestException)
            {
                return Problem(
                    title: "Unable to retrieve NHL schedule",
                    statusCode: StatusCodes.Status502BadGateway);
            }
            catch (InvalidOperationException)
            {
                return Problem(
                title: "NHL schedule data was unavailable.",
                statusCode: StatusCodes.Status502BadGateway
                    );
            }
        }

    }
}
