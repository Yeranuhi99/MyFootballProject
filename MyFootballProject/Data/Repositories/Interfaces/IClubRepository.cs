using MyFootballProject.Data.Entities;

namespace MyFootballProject.Data.Repositories.Interfaces
{
    public interface IClubRepository
    {
        void Add(Club Club);
        Club GetById(int id);
        List<Club> GetAll();
        void Delete(Club Club);
        void SaveChanges();
    }
}
