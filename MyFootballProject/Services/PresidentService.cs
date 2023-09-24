using MyFootballProject.Data.Repositories;
using MyFootballProject.Data.Entities;
using MyFootballProject.Data.Repositories.Interfaces;
using MyFootballProject.Services.Interfaces;
using MyFootballProject.ViewModels;

namespace MyFootballProject.Services
{
    public class PresidentService : IPresidentService
    {
        private readonly IPresidentRepository _presidentrepository;
        public PresidentService(IPresidentRepository presidentrepository)
        {
            _presidentrepository = presidentrepository;
        }
        public void Add(PresidentAddEditVM President)
        {
            President president = new President()
            {
                FirstName = President.FirstName,
                LastName = President.LastName,
                DOB = President.DOB,
                Country = President.Country,
            };
            _presidentrepository.Add(president);
        }

        public void Delete(int id)
        {
            var entity = _presidentrepository.GetById(id);
            _presidentrepository.Delete(entity);
        }

        public PresidentAddEditVM GetById(int id)
        {
            var entity = _presidentrepository.GetById(id);
            return new PresidentAddEditVM
            {
                Id = entity.Id,
                FirstName= entity.FirstName,
                LastName= entity.LastName,
                DOB= entity.DOB,
                Country = entity.Country,
            };
        }

        public List<PresidentDropDownVM> GetListForDropdown()
        {
            var data = _presidentrepository.GetAll();
            return data.Select(p => new PresidentDropDownVM
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LasttName = p.LastName,   
            }).ToList();
        }

        public void Update(PresidentAddEditVM President)
        {
            var entity = _presidentrepository.GetById(President.Id);
            entity.FirstName= President.FirstName;
            entity.LastName= President.LastName;
            entity.DOB= President.DOB;
            entity.Country= President.Country;
        }
    }
}
