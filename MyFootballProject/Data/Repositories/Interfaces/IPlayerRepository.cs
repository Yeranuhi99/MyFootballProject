using MyFootballProject.Data.Entities;

namespace MyFootballProject.Data.Repositories.Interfaces
{
    public interface IPlayerRepository
    {
        void Add(Player Player);
        Player GetById(int id);
        List<Player> GetAll();
        void Delete(Player Player);
        void SaveChanges();
    }
}
