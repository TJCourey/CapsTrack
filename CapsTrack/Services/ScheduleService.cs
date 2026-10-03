using CapsTrack.api.Clients;
using CapsTrack.api.Models;
using CapsTrack.api.Mappers;


namespace CapsTrack.api.Services
{
    public class ScheduleService : IScheduleService
    {
        private readonly INhlClient _nhlClient;

        public ScheduleService(INhlClient nhlClient)
        {
            _nhlClient = nhlClient;
        }

        public async Task<ScheduleModel> GetTeamScheduleAsync(
            string teamAbbreviation,
            string season,
            CancellationToken cancellationToken = default)
        {
            var nhlSchedule = await _nhlClient.GetTeamScheduleAsync(
                teamAbbreviation,
                season,
                cancellationToken);

            if (nhlSchedule is null)
            {
                throw new InvalidOperationException(
                    "NHL schedule response was empty.");
            }

            return nhlSchedule.ToModel(teamAbbreviation);
        }
    }
}
