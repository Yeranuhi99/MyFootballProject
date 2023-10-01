using MyFootballProject.Data.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFootballProject.Data.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public DateTime DOB { get; set; }
        public Country Country { get; set; }
        public Position Position { get; set; }
        public string? NationalTeam { get; set; }
        [ForeignKey("Club")]
        public int ClubId { get; set; }
        public Club Club { get; set; }
        public string ImageName { get; set; }

    }
}
