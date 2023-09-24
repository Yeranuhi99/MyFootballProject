namespace MyFootballProject.Data.Entities
{
    public class Stadium
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FoundingDate { get; set; }
        public string Address { get; set; }
        public long Capacity { get; set; }
        public List<Club> Clubs { get; set; }
    }
}
