using CapsTrack.api.Models.Nhl;

namespace CapsTrack.api.Clients
{
    public interface INhlClient
    {
        Task<NhlScheduleResponse?> GetTeamScheduleAsync(
            string teamAbbreviation,
            string season,
            CancellationToken cancellationToken = default);
    }
}
