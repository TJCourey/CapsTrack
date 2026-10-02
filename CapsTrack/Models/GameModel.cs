namespace CapsTrack.api.Models
{
    public class GameModel
    {
        public long GameId { get; set; }
        public DateTime GameDate { get; set; }
        public int Season { get; set; }
        public string? HomeTeam { get; set; }
        public string? AwayTeam { get; set; }
        public int? HomeScore { get; set; }
        public int? AwayScore { get; set; }
        public GameStatus Status{ get; set; }
    }
    public enum GameStatus
    {
        Scheduled,
        Live,
        Final,
        Unknown
    }
}
