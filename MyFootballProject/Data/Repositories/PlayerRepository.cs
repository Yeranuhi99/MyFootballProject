using MyFootballProject.Data.Entities;
using MyFootballProject.Data.Repositories.Interfaces;

namespace MyFootballProject.Data.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly FootballDataContext _context;
        public PlayerRepository(FootballDataContext context)
        {
            _context = context;
        }
        public void Add(Player Player)
        {
            _context.Add(Player);
            _context.SaveChanges();
        }

        public void Delete(Player Player)
        {

            _context.Remove(Player);
            _context.SaveChanges();
        }

        public List<Player> GetAll()
        {
            var entity = _context.Players.ToList();
            return entity;
        }

        public Player GetById(int id)
        {
            var entity = _context.Players.Find(id);
            return entity;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
