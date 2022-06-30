using System;
using BonteBeestenBoel.Activities;

namespace BonteBeestenBoel.Workers
{
    public class Worker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsFullTime { get; set; }

        public int StartHour { get; protected set; } = 8;
        public int StopHour { get; protected set; } = 16;

        public Worker(string name, string lastName, bool fullTime)
        {
            this.FirstName = name;
            this.LastName = lastName;
            this.IsFullTime = fullTime;
        }

        public virtual bool CanPerformActivity(IActivity activity)
        {
            return false;
        }

        public override string ToString()
        {
            string time = IsFullTime ? "Voltijds" : "Halftijds";
            return this.FirstName + " " + this.LastName + Environment.NewLine +
                   "  " + time;
        }
    }
}