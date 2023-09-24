using MyFootballProject.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFootballProject.ViewModels
{
    public class CoachAddEditVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public int ClubId { get; set; }
    }
}
