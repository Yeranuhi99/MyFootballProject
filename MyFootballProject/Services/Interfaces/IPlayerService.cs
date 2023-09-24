using MyFootballProject.ViewModels;

namespace MyFootballProject.Services.Interfaces
{
    public interface IPlayerService
    {
        public void Add(PlayerAddEditVM Player);
        public void Update(PlayerAddEditVM Player);
        public PlayerAddEditVM GetById(int id);
        public void Delete(int id);
    }
}
