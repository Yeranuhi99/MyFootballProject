using MyFootballProject.Data.Entities;

namespace MyFootballProject.Data.Repositories.Interfaces
{
    public interface ICoachRepository
    {
        int Add(Coach Coach);
        Coach GetById(int id);
        List<Coach> GetAll();
        void Delete(Coach Coach);
        void SaveChanges();
    }
}
