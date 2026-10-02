using CapsTrack.api.Models;
using CapsTrack.api.Models.Nhl;

namespace CapsTrack.api.Mappers
{
    public static class ScheduleMapper
    {
        public static ScheduleModel ToModel(
            this NhlScheduleResponse nhlSchedule,
            string teamAbbreviation,)
        {
            ArgumentNullException.ThrowIfNull(nhlSchedule);

            return new ScheduleModel
            { TeamAbbrv = teamAbbreviation.ToUpper(),
              Season = nhlSchedule.CurrentSeason 
                ?? throw new InvalidOperationException(
                    "NHL Response did not contain season info"),

              Games = []

            };
        }
        
    }
}
