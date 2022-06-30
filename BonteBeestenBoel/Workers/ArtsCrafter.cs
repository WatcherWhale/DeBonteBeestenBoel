using System;
using BonteBeestenBoel.Activities;

namespace BonteBeestenBoel.Workers
{
    public class ArtsCrafter : Worker
    {
        public ArtsCrafter(string name, string lastName, bool fulltime) : base(name, lastName, fulltime)
        {
            if (!IsFullTime) this.StartHour = 12;
        }

        public override bool CanPerformActivity(IActivity activity)
        {
            return activity.Category == Category.ArtsCrafter;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "  Arts & Crafter";
        }
    }
}

// 10 min