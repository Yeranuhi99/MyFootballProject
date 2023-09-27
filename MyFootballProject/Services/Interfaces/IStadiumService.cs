using MyFootballProject.Data.Entities;
using MyFootballProject.ViewModels;

namespace MyFootballProject.Services.Interfaces
{
    public interface IStadiumService
    {
        public void Add(StadiumAddEditVM Stadium);
        public void Update(StadiumAddEditVM Stadium);
        public StadiumAddEditVM GetById(int id);
        public void Delete(int id);
        public List<StadiumDropDownVM> GetListForDropdown();
        public List<StadiumAddEditVM> GetAll();
    }
}
