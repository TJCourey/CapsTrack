using CapsTrack.api.Models.Nhl;

namespace CapsTrack.api.Clients
{
    public interface INhlClient
    {
        Task<NhlScheduleResponse?> GetTeamScheduleAsync(
            string teamAbbreviation,
            String season,
            CancellationToken cancellationToken = default);
    }
}
