using CapsTrack.api.Clients;

namespace CapsTrack.api.Services
{
    public class ScheduleService
    {
        private readonly NhlClient _nhlClient;

        public ScheduleService(NhlClient nhlClient)
        {
            _nhlClient = nhlClient;
        }
    }
}
