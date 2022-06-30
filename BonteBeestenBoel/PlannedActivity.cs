using BonteBeestenBoel.Activities;
using BonteBeestenBoel.Workers;

namespace BonteBeestenBoel
{
    public class PlannedActivity
    {
        public int StartHour { get; set; }
        public Worker Worker { get; set; }
        public IActivity Activity { get; set; }
        
        // TODO: Add ToString override
    }
}