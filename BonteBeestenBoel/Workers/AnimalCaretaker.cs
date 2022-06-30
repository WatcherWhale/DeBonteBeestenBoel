using System;
using BonteBeestenBoel.Activities;

namespace BonteBeestenBoel.Workers
{
    public class AnimalCaretaker : Worker
    {
        private int _feeding = 0;

        public AnimalCaretaker(string name, string lastName) : base(name, lastName, true)
        {
            if (!IsFullTime) throw new ArgumentException("Animal Caretakers can't work fulltime.");
        }

        public override bool CanPerformActivity(IActivity activity)
        {

            if (activity.Name == "Dieren voederen")
            {
                if (_feeding >= 1) return false;
                _feeding++;
            }
            
            return activity.Category == Category.AnimalCareTaker;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "  Animal Caretaker";
        }
    }
}