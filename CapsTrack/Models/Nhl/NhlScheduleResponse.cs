namespace CapsTrack.api.Models.Nhl
{
    public class NhlScheduleResponse
    {
        public int? PreviousSeason { get; set; }

        public int? CurrentSeason { get; set; }

        public int? NextSeason { get; set; }

        public List<NhlGame> Games { get; set; } = [];
    }

    public class NhlGame
    {
        public long Id { get; set; }
        public int Season { get; set; }
        public DateOnly GameDate { get; set; }
        public string? GameState { get; set; }

        public NhlTeam HomeTeam { get; set; } = new();
        public NhlTeam AwayTeam { get; set; } = new();
    }
    public class NhlTeam
    {
        public string Abbrev { get; set; } = string.Empty;
        public int? Score { get; set; }
    }
}
