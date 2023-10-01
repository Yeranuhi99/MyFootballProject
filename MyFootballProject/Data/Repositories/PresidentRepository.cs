using MyFootballProject.Data.Entities;
using MyFootballProject.Data.Repositories.Interfaces;

namespace MyFootballProject.Data.Repositories
{
    public class PresidentRepository : IPresidentRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly FootballDataContext _context;
        public PresidentRepository(FootballDataContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }
        public int Add(President President)
        {
            _context.Add(President);
            _unitOfWork.Save();
            return President.Id;
        }

        public void Delete(President President)
        {
            _context.Remove(President);
            _unitOfWork.Save();
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
            _unitOfWork.Save();
        }
    }
}
