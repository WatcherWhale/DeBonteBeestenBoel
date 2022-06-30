namespace BonteBeestenBoel.Activities
{
    public class Activity : IActivity
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public Category Category { get; set; }
        public int Capacity { get; set; }
    }
}