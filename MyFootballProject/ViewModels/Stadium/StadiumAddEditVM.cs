using MyFootballProject.Data.Entities;

namespace MyFootballProject.ViewModels
{
    public class StadiumAddEditVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FoundingDate { get; set; }
        public string Address { get; set; }
        public long Capacity { get; set; }
    }
}
