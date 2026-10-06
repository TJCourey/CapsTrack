using CapsTrack.api.Mappers;
using CapsTrack.api.Models;
using CapsTrack.api.Models.Nhl;

namespace CapsTrack.Api.Tests.Mappers
{
    public class GameScheduleMapperTest
    {
        [Fact]
        public void ToModel_MapsNhlScheduleResponseToScheduleModel()
        {
            var nhlSchedule = new NhlScheduleResponse
            {
                CurrentSeason = 20262027,
                Games =
                [
                    new NhlGame
                    {
                        Id = 1,
                        Season = 20262027,
                        GameDate = new DateOnly(2026, 10, 1),
                        GameState = "FINAL",
                        HomeTeam = new NhlTeam
                        {
                            Abbrev = "WSH",
                            Score = 4
                        },
                        AwayTeam = new NhlTeam
                        {
                            Abbrev = "PIT",
                            Score = 3
                        }
                    },
                     new NhlGame
                    {
                        Id = 2,
                        Season = 20262027,
                        GameDate = new DateOnly(2026, 10, 10),
                        GameState = "FUT",
                        HomeTeam = new NhlTeam
                        {
                            Abbrev = "NYR"
                        },
                        AwayTeam = new NhlTeam
                        {
                            Abbrev = "WSH"
                        }
                    }
                ]
            };
            var result = nhlSchedule.ToModel("wsh");

            Assert.Equal("WSH", result.TeamAbbrv);
            Assert.Equal(20262027, result.Season);
            Assert.Equal(2, result.Games.Count);

            Assert.Equal(1, result.Games[0].GameId);
            Assert.Equal(GameStatus.Final, result.Games[0].Status);

            Assert.Equal(2, result.Games[1].GameId);
            Assert.Equal(GameStatus.Scheduled, result.Games[1].Status);

        }
    }
}
