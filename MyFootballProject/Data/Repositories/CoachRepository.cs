using MyFootballProject.Data.Entities;
using MyFootballProject.Data.Repositories.Interfaces;

namespace MyFootballProject.Data.Repositories
{
    public class CoachRepository : ICoachRepository
    {
        private readonly FootballDataContext _context;
        public CoachRepository(FootballDataContext context)
        {
            _context = context;
        }
        public void Add(Coach Coach)
        {
            _context.Add(Coach);
            _context.SaveChanges();
        }

        public void Delete(Coach Coach)
        {
            _context.Remove(Coach);
            _context.SaveChanges();
        }

        public List<Coach> GetAll()
        {
            var entity = _context.Coaches.ToList();
            return entity;
        }

        public Coach GetById(int id)
        {
            var entity = _context.Coaches.Find(id);
            return entity;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
