namespace CapsTrack.api.Models
{
    public class ScheduleModel
    {
        public string? TeamAbbrv { get; set; }
        public int Season { get; set; }
        public List<GameModel> Games { get; set; } = new List<GameModel>();
    }
}
