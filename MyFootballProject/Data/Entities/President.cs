using MyFootballProject.Data.Enum;

namespace MyFootballProject.Data.Entities
{
    public class President
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public Country Country { get; set; }
        public List<Club> Clubs { get; set; }
    }
}
