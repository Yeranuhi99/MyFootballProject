using MyFootballProject.Data.Entities;
using MyFootballProject.Data.Repositories.Interfaces;

namespace MyFootballProject.Data.Repositories
{
    public class StadiumRepository : IStadiumRepository
    {
        private readonly FootballDataContext _context;
        public StadiumRepository(FootballDataContext context)
        {
            _context = context;
        }
        public void Add(Stadium Stadium)
        {
            _context.Add(Stadium);
            _context.SaveChanges();
        }

        public void Delete(Stadium Stadium)
        {
            _context.Remove(Stadium);
            _context.SaveChanges();
        }

        public List<Stadium> GetAll()
        {
            var entity = _context.Stadiums.ToList();
            return entity;
        }

        public Stadium GetById(int id)
        {
            var entity = _context.Stadiums.Find(id);
            return entity;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
