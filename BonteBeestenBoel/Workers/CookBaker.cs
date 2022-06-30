using System;
using BonteBeestenBoel.Activities;

namespace BonteBeestenBoel.Workers
{
    public class CookBaker : Worker
    {
        public CookBaker(string name, string lastName, bool fulltime) : base(name, lastName, fulltime)
        {
            if (!IsFullTime) StopHour = 12;
        }

        public override bool CanPerformActivity(IActivity activity)
        {
            return activity.Category == Category.CookBaker;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "  Cook & Baker";
        }
    }
}