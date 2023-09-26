using MyFootballProject.Data.Repositories;
using MyFootballProject.Data.Entities;
using MyFootballProject.Data.Repositories.Interfaces;
using MyFootballProject.Services.Interfaces;
using MyFootballProject.ViewModels;

namespace MyFootballProject.Services
{
    public class StadiumService : IStadiumService
    {
        private readonly IStadiumRepository _stadiumrepository;
        public StadiumService(IStadiumRepository stadiumrepository)
        {
            _stadiumrepository = stadiumrepository;
        }
        public void Add(StadiumAddEditVM Stadium)
        {
            Stadium stadium = new Stadium()
            {
                Name = Stadium.Name,
                FoundingDate = DateTime.Now,
                Address = Stadium.Address,
                Capacity = Stadium.Capacity,
            };
            _stadiumrepository.Add(stadium);
        }

        public void Delete(int id)
        {
           var entity = _stadiumrepository.GetById(id);
        _stadiumrepository.Delete(entity);
        }

        public List<Stadium> GetAll()
        {
            var data = _stadiumrepository.GetAll();
            return data;
        }

        public StadiumAddEditVM GetById(int id)
        {
            var entity = _stadiumrepository.GetById(id);
            return new StadiumAddEditVM
            {
                Id = entity.Id,
                Name = entity.Name,
                Address = entity.Address,
                Capacity = entity.Capacity,
            };
        }

        public List<StadiumDropDownVM> GetListForDropdown()
        {
            var data = _stadiumrepository.GetAll();
            return data.Select(f => new StadiumDropDownVM
            {
                Id = f.Id,
                Name = f.Name,
            }).ToList();
        }

        public void Update(StadiumAddEditVM Stadium)
        {
            var entity = _stadiumrepository.GetById(Stadium.Id);
            entity.Name = Stadium.Name;
            entity.Address = Stadium.Address;
            entity.Capacity = Stadium.Capacity;
        }
    }
}
