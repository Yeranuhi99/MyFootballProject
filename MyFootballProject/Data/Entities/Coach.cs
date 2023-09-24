using System.ComponentModel.DataAnnotations.Schema;

namespace MyFootballProject.Data.Entities
{
    public class Coach
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }

        [ForeignKey("Club")]
        public int ClubId { get; set; }
        public Club Club { get; set; }

    }
}
