using MyFootballProject.Data.Entities;
using MyFootballProject.Data.Repositories.Interfaces;

namespace MyFootballProject.Data.Repositories
{
    public class ClubRepository : IClubRepository
    {
        private readonly FootballDataContext _context;
        public ClubRepository(FootballDataContext context)
        {
            _context = context;
        }
        public void Add(Club Club)
        {
            _context.Add(Club);
            _context.SaveChanges();
        }

        public void Delete(Club Club)
        {
            _context.Remove(Club);
            _context.SaveChanges();
        }

        public List<Club> GetAll()
        {
            var entity = _context.Clubs.ToList();
            return entity;
        }

        public Club GetById(int id)
        {
            var entity = _context.Clubs.Find(id);
            return entity;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
