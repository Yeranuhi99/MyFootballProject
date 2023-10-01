using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using MyFootballProject.Data.Enum;

namespace MyFootballProject.ViewModels
{
    public class ClubAddEditVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FoundingDate { get; set; }
        public League League { get; set; }
        public Country Country { get; set; }
        public int PresidentId { get; set; }
        public int StadiumId { get; set; }
        public string PresidentName { get; set; }
        public string StadiumName { get; set; }
        public string FileName { get; set; }
    }
    
}
