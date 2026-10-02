using CapsTrack.api.Models;

namespace CapsTrack.api.Mappers
{
    public static class GameStatusMapper
    {
        public static GameStatus ToGameStatus(this string? nhlGameState)
        {
            return nhlGameState?.ToUpperInvariant() switch
            {
                "FUT" => GameStatus.Scheduled,
                "PRE" => GameStatus.Scheduled,

                "LIVE" => GameStatus.Live,
                "CRIT" => GameStatus.Live,

                "OFF" => GameStatus.Final,
                "FINAL" => GameStatus.Final,

                _ => GameStatus.Unknown
            };
        }
    }
}
