using MyFootballProject.ViewModels;

namespace MyFootballProject.Services.Interfaces
{
    public interface IPresidentService
    {
        public void Add(PresidentAddEditVM President);
        public void Update(PresidentAddEditVM President);
        public PresidentAddEditVM GetById(int id);
        public void Delete(int id);
    }
}
