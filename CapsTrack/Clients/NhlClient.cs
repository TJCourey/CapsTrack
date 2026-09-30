using CapsTrack.api.Models.Nhl;

namespace CapsTrack.api.Clients
{
    public class NhlClient : INhlClient
    {
        private readonly HttpClient _httpClient;
        public NhlClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<NhlScheduleResponse?> GetTeamScheduleAsync(
            string teamAbbreviation,
            string season,
            CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync(
                $"v1/club-schedule-season/{teamAbbreviation}/{season}",
                cancellationToken);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<NhlScheduleResponse>(
               cancellationToken: cancellationToken);
        }
    }
}
