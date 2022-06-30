using System;
using BonteBeestenBoel.Activities;
using BonteBeestenBoel.Workers;

namespace BonteBeestenBoel
{
    public class PlannedActivity
    {
        public int StartHour { get; set; }
        public Worker Worker { get; set; }
        public IActivity Activity { get; set; }

        public override string ToString()
        {
            return this.Activity.Name + ":" + Environment.NewLine +
                   "    " + StartHour.ToString() + "u - " + (StartHour + Activity.Duration).ToString() + "u" +
                   Environment.NewLine +
                   "    " + Worker.FirstName + " " + Worker.LastName;
        }
    }
}