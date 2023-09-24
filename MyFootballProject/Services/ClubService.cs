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
        public void Update(ClubAddEditVM Club)
        {
            var entity = _clubRepository.GetById(Club.Id);
            entity.Name = Club.Name;
            entity.FoundingDate = Club.FoundingDate;
            entity.League = Club.League; 
            entity.Country = Club.Country;
            entity.PresidentId = Club.PresidentId;
            entity.StadiumId = Club.StadiumId;
        }
    }
}
