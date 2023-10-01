using Microsoft.EntityFrameworkCore;
using MyFootballProject.Data.Entities;

namespace MyFootballProject.Data
{
    public class FootballDataContext: DbContext
    {
        public FootballDataContext(DbContextOptions<FootballDataContext> options) : base(options) { }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<President> Presidents { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
    }
}
