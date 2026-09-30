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
    }
}
