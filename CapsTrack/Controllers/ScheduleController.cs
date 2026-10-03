using CapsTrack.api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace CapsTrack.api.Controllers
{
    [ApiController]
    [Route("api/team/schedule")]
        
    
    public class GetScheduleController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get(string teamAbbreviation, string season)
        {
            var scheduleModel = new ScheduleModel();


            return Ok(scheduleModel);
        }

    }
}
