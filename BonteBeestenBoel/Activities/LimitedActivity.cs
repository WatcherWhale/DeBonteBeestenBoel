namespace BonteBeestenBoel.Activities
{
    public class LimitedActivity : IActivity
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public Category Category { get; set; }
        public int Capacity { get; set; }

        public int Max { get; set; }
        public int Performed { get; set; } = 0;
    }
}