using MyFootballProject.Data.Entities;
using MyFootballProject.Data.Repositories.Interfaces;

namespace MyFootballProject.Data.Repositories
{
    public class CoachRepository : ICoachRepository
    {
        private readonly FootballDataContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public CoachRepository(FootballDataContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork= unitOfWork;
        }
        public int Add(Coach Coach)
        {
            _context.Add(Coach);
            _unitOfWork.Save();
            return Coach.Id;    
        }

        public void Delete(Coach Coach)
        {
            _context.Remove(Coach);
            _unitOfWork.Save();
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
            _unitOfWork.Save();
        }
    }
}
