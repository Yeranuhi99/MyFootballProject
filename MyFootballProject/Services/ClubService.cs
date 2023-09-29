using MyFootballProject.Data.Repositories;
using MyFootballProject.Data.Entities;
using MyFootballProject.Services.Interfaces;
using MyFootballProject.ViewModels;
using MyFootballProject.Data.Repositories.Interfaces;

namespace MyFootballProject.Services
{
    public class ClubService : IClubService
    {
        private readonly IClubRepository _clubRepository;
        public ClubService(IClubRepository clubRepository)
        {
                _clubRepository = clubRepository;
        }
        public void Add(ClubAddEditVM Club)
        {
            Club club = new Club()
            {
                Name = Club.Name,
                FoundingDate = Club.FoundingDate,
                League = Club.League,
                Country = Club.Country,
                PresidentId = Club.PresidentId,
                StadiumId = Club.StadiumId,
            };
            _clubRepository.Add(club);
        }

        public void Delete(int id)
        {
            var entity = _clubRepository.GetById(id);
            _clubRepository.Delete(entity);

        }

        public List<ClubAddEditVM> GetAll()
        {
            var data = _clubRepository.GetAll();
            var clublist = data.Select(c => new ClubAddEditVM
            {
                Id = c.Id,
                Name = c.Name,
                FoundingDate = c.FoundingDate,
                League = c.League,
                Country = c.Country,
                PresidentId = c.PresidentId,
                StadiumId = c.StadiumId,
                PresidentName = c.President.FirstName + " " + c.President.LastName,
                StadiumName = c.Stadium.Name
            }).ToList();
            return clublist;
        }

        public ClubAddEditVM GetById(int id)
        {
            var entity = _clubRepository.GetById(id);
            return new ClubAddEditVM
            {
                Id = entity.Id,
                Name = entity.Name,
                FoundingDate = entity.FoundingDate,
                League = entity.League,
                Country = entity.Country,
                PresidentId = entity.PresidentId,
                StadiumId = entity.StadiumId,
            };
        }

        public List<ClubDropDownVM> GetListForDropdown()
        {
            var data = _clubRepository.GetAll();
            return data.Select(f => new ClubDropDownVM
            {
                Id = f.Id,
                Name = f.Name,
            }).ToList();
        }

        public void Update(ClubAddEditVM Club)
        {
            var entity = _clubRepository.GetById(Club.Id);
            entity.Name = Club.Name;
            entity.FoundingDate = Club.FoundingDate;
            entity.League = Club.League; 
            entity.Country = Club.Country;
            entity.PresidentId = Club.PresidentId;
            entity.StadiumId = Club.StadiumId;
            _clubRepository.SaveChanges();
        }
    }
}
