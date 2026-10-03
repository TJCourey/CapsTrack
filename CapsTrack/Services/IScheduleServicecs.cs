using CapsTrack.api.Models;

namespace CapsTrack.api.Services
{
    public interface IScheduleServicecs
    {
        Task<ScheduleModel?> GetTeamScheduleAsync(
            string teamAbbreviation,
            string season,
            CancellationToken cancellationToken = default);
    }
}
