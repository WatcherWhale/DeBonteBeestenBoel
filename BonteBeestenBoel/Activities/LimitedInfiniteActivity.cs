namespace BonteBeestenBoel.Activities
{
    public class LimitedInfiniteActivity : LimitedActivity
    {
        public new int Capacity { get; set; } = 10;
    }
}