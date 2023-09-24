using MyFootballProject.Data.Entities;
using MyFootballProject.Data.Enum;

namespace MyFootballProject.ViewModels
{
    public class PresidentAddEditVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public Country Country { get; set; }
    }
}
