using MyFootballProject.Data.Entities;
using Microsoft.EntityFrameworkCore;
using MyFootballProject.Data.Repositories.Interfaces;

namespace MyFootballProject.Data.Repositories
{
    public class ClubRepository : IClubRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly FootballDataContext _context;
        public ClubRepository(FootballDataContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }
        public int Add(Club Club)
        {
            _context.Add(Club);
            _unitOfWork.Save();
            return Club.Id;
        }

        public void Delete(Club Club)
        {
            _context.Remove(Club);
            _unitOfWork.Save();
        }

        public List<Club> GetAll()
        {
            var entity = _context.Clubs.Include(c=>c.President).Include(s=>s.Stadium).ToList();
            return entity;
        }

        public Club GetById(int id)
        {
            var entity = _context.Clubs.Find(id);
            return entity;
        }

        public void SaveChanges()
        {
            _unitOfWork.Save();
        }
    }
}
