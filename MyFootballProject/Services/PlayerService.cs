using MyFootballProject.Data.Repositories;
using MyFootballProject.Data.Entities;
using MyFootballProject.Services.Interfaces;
using MyFootballProject.ViewModels;
using MyFootballProject.Data.Repositories.Interfaces;

namespace MyFootballProject.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerrepository;
        public PlayerService(IPlayerRepository playerrepository)
        {
            _playerrepository = playerrepository;
        }
        public void Add(PlayerAddEditVM Player)
        {
            Player player = new Player()
            {
                FirstName = Player.FirstName,
                LastName = Player.LastName,
                DOB = Player.DOB,
                Country = Player.Country,
                Position = Player.Position,
                NationalTeam = Player.NationalTeam,
                ClubId = Player.ClubId,
            };
        }

        public void Delete(int id)
        {
            var entity = _playerrepository.GetById(id);
            _playerrepository.Delete(entity);
        }

        public PlayerAddEditVM GetById(int id)
        {
            var entity = _playerrepository.GetById(id);
            return new PlayerAddEditVM
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                DOB = entity.DOB,
                Country = entity.Country,
                Position = entity.Position,
                NationalTeam = entity.NationalTeam,
                ClubId = entity.ClubId,
            };
        }

        public void Update(PlayerAddEditVM Player)
        {
            var entity = _playerrepository.GetById(Player.Id);
            entity.FirstName = Player.FirstName;
            entity.LastName = Player.LastName;
            entity.DOB = Player.DOB;
            entity.Country = Player.Country;
            entity.Position = Player.Position;
            entity.NationalTeam= Player.NationalTeam;
        }
    }
}
