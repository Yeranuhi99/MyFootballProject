using MyFootballProject.Data.Entities;
using MyFootballProject.Data.Repositories.Interfaces;

namespace MyFootballProject.Data.Repositories
{
    public class StadiumRepository : IStadiumRepository
    {
        private readonly FootballDataContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public StadiumRepository(FootballDataContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }
        public int Add(Stadium Stadium)
        {
            _context.Add(Stadium);
            _unitOfWork.Save();
            return Stadium.Id;
        }

        public void Delete(Stadium Stadium)
        {
            _context.Remove(Stadium);
            _unitOfWork.Save();
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
            _unitOfWork.Save();
        }
    }
}
