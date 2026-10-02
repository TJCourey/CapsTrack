using System;
using CapsTrack.api.Models;
using CapsTrack.api.Models.Nhl;

namespace CapsTrack.api.Mappers
{
    public static class GameMapper
    {
        public static GameModel ToModel(this NhlGame nhlGame)
        {
            ArgumentNullException.ThrowIfNull(nhlGame);

            return new GameModel
            {
                GameId = nhlGame.Id,
                GameDate = nhlGame.GameDate.ToDateTime(TimeOnly.MinValue),
                Season = nhlGame.Season,
                HomeTeam = nhlGame.HomeTeam.Abbrev,
                AwayTeam = nhlGame.AwayTeam.Abbrev,
                HomeScore = nhlGame.HomeTeam.Score,
                AwayScore = nhlGame.AwayTeam.Score,
                GameStatus = nhlGame.GameState
            };
        }
    }
}
