using CapsTrack.api.Clients;
using CapsTrack.api.Models.Nhl;
using CapsTrack.api.Services;

namespace CapsTrack.Api.Tests.Services
{
    public class ScheduleServiceTest
    {
        [Fact]
        public async Task GetTeamScheduleAsync_ReturnsMappedSchedule()
        {
            // Arrange
            var fakeClient = new FakeNhlClient();

            var service = new ScheduleService(fakeClient);

            using var cancellationTokenSource = new CancellationTokenSource();
            var cancellationToken = cancellationTokenSource.Token;

            // Act
            var result = await service.GetTeamScheduleAsync(
                "wsh",
                "20262027",
                cancellationToken);

            // Assert
            Assert.Equal("WSH", result.TeamAbbrv);
            Assert.Equal(20262027, result.Season);
            Assert.Single(result.Games);

            Assert.Equal("wsh", fakeClient.TeamAbbreviation);
            Assert.Equal("20262027", fakeClient.Season);
            Assert.Equal(cancellationToken, fakeClient.CancellationToken);
        }

        private class FakeNhlClient : INhlClient
        {
            public string? TeamAbbreviation { get; private set; }
            public string? Season { get; private set; }
            public CancellationToken CancellationToken { get; private set; }

            public Task<NhlScheduleResponse?> GetTeamScheduleAsync(
                string teamAbbreviation,
                string season,
                CancellationToken cancellationToken = default)
            {
                TeamAbbreviation = teamAbbreviation;
                Season = season;
                CancellationToken = cancellationToken;

                var response = new NhlScheduleResponse
                {
                    CurrentSeason = 20262027,
                    Games =
                    [
                        new NhlGame
                        {
                            Id = 1,
                            Season = 20262027,
                            GameDate = new DateOnly(2026, 10, 8),
                            GameState = "FINAL",
                            HomeTeam = new NhlTeam
                            {
                                Abbrev = "WSH",
                                Score = 4
                            },
                            AwayTeam = new NhlTeam
                            {
                                Abbrev = "PIT",
                                Score = 2
                            }
                        }
                    ]
                };

                return Task.FromResult<NhlScheduleResponse?>(response);
            }
        }
    }
}