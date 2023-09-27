using MyFootballProject.ViewModels;

namespace MyFootballProject.Services.Interfaces
{
    public interface IClubService
    {
        public void Add(ClubAddEditVM Club);
        public void Update(ClubAddEditVM Club);
        public ClubAddEditVM GetById(int id);
        public void Delete(int id);
        public List<ClubDropDownVM> GetListForDropdown();
        public List<ClubAddEditVM> GetAll();
    }
}
