namespace BonteBeestenBoel.Activities
{
    public enum Category
    {
        AnimalCareTaker = 1,
        CookBaker = 2,
        ArtsCrafter = 3
    }

    public interface IActivity
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public Category Category { get; set; }
    }
}