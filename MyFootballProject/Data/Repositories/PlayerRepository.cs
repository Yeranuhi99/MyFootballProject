using Microsoft.EntityFrameworkCore;
using MyFootballProject.Data.Entities;
using MyFootballProject.Data.Repositories.Interfaces;

namespace MyFootballProject.Data.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly FootballDataContext _context;
        public PlayerRepository(FootballDataContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }
        public int Add(Player Player)
        {
            _context.Add(Player);
            _unitOfWork.Save();
            return Player.Id;
        }

        public void Delete(Player Player)
        {

            _context.Remove(Player);
            _context.SaveChanges();
        }

        public List<Player> GetAll()
        {
            var entity = _context.Players.Include(c => c.Club).ToList();
            return entity;
        }

        public Player GetById(int id)
        {
            var entity = _context.Players.Find(id);
            return entity;
        }

        public void SaveChanges()
        {
            _unitOfWork.Save();
        }
    }
}
