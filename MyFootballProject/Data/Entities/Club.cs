using MyFootballProject.Data.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFootballProject.Data.Entities
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FoundingDate { get; set; }
        public League League { get; set; }
        public Country Country { get; set; }
        public List<Player> Players { get; set; }
        public List<Coach> Coaches { get; set; }
        [ForeignKey("President")]
        public int PresidentId { get; set; }
        public President President { get; set; }
        [ForeignKey("Stadium")]
        public int StadiumId { get; set; }
        public Stadium Stadium { get; set; }
        public string LogoImage { get; set; }
    }
}
