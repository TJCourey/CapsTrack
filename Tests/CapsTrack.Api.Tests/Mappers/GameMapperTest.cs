using CapsTrack.api.Mappers;
using CapsTrack.api.Models;
using CapsTrack.api.Models.Nhl;

namespace CapsTrack.Api.Tests.Mappers
{
    public class GameMapperTest
    {
        [Fact]
        public void ToModel_MapsNhlGameToGameModel()
        {
            // Arrange
            var nhlGame = new NhlGame
            {
                Id = 2026020001,
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
            };

            // Act
            var result = nhlGame.ToModel();

            // Assert
            Assert.Equal(2026020001, result.GameId);
            Assert.Equal(20262027, result.Season);
            Assert.Equal(new DateTime(2026, 10, 8), result.GameDate);

            Assert.Equal("WSH", result.HomeTeam);
            Assert.Equal("PIT", result.AwayTeam);

            Assert.Equal(4, result.HomeScore);
            Assert.Equal(2, result.AwayScore);

            Assert.Equal(GameStatus.Final, result.Status);
        }
    }
}