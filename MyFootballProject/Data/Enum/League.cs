using System.ComponentModel.DataAnnotations;
namespace MyFootballProject.Data.Enum
{
    public enum League
    {
        LaLiga=1,
        [Display(Name = "Premier League")]
        Premier_League,
        Bundesliga,
        [Display(Name = "Serie A")]
        Serie_A,
        [Display(Name = "Ligue 1")]
        Ligue_1,
        [Display(Name = "Armenian Premier League")]
        Armenian_Premier_League
    }
}
