using MyFootballProject.ViewModels;

namespace MyFootballProject.Services.Interfaces
{
    public interface ICoachService
    {
        public void Add(CoachAddEditVM Coach);
        public void Update(CoachAddEditVM Coach);
        public CoachAddEditVM GetById(int id);
        public void Delete(int id);
        public List<CoachAddEditVM> GetAll();
    }
}
