using MyFootballProject.Data.Entities;
using MyFootballProject.Data.Repositories.Interfaces;

namespace MyFootballProject.Data.Repositories
{
    public class PresidentRepository : IPresidentRepository
    {
        private readonly FootballDataContext _context;
        public PresidentRepository(FootballDataContext context)
        {
            _context = context;
        }
        public void Add(President President)
        {
            _context.Add(President);
            _context.SaveChanges();
        }

        public void Delete(President President)
        {
            _context.Remove(President);
            _context.SaveChanges();
        }

        public List<President> GetAll()
        {
            var entity = _context.Presidents.ToList();
            return entity;
        }

        public President GetById(int id)
        {
            var entity = _context.Presidents.Find(id);
            return entity;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
