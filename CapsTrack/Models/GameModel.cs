namespace CapsTrack.api.Models
{
    public class GameModel
    {
        public int gameId { get; set; }
        public DateTime gameDate { get; set; }
        public int season { get; set; }
        public string homeTeam { get; set; } = string.Empty;
        public string awayTeam { get; set; } = string.Empty;
        public int? homeScore { get; set; }
        public int? awayScore { get; set; }
        public string? gameStatus { get; set; }
    }
}
