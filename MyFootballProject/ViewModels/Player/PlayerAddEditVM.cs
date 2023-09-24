using MyFootballProject.Data.Entities;
using MyFootballProject.Data.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFootballProject.ViewModels
{
    public class PlayerAddEditVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public Country Country { get; set; }
        public Position Position { get; set; }
        public string? NationalTeam { get; set; }
        public int ClubId { get; set; }
    }
}
