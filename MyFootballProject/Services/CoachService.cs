using MyFootballProject.Data.Repositories;
using MyFootballProject.Data.Entities;
using MyFootballProject.Data.Repositories.Interfaces;
using MyFootballProject.Services.Interfaces;
using MyFootballProject.ViewModels;

namespace MyFootballProject.Services
{
    public class CoachService : ICoachService
    {
        private readonly ICoachRepository _coachrepository;
        public CoachService(ICoachRepository coachrepository)
        {
            _coachrepository = coachrepository;
        }
        public void Add(CoachAddEditVM Coach)
        {
            Coach coach = new Coach()
            {
                FirstName = Coach.FirstName,
                LastName = Coach.LastName,
                DOB = Coach.DOB,
                ClubId = Coach.ClubId,
            };
            _coachrepository.Add(coach);
        }

        public void Delete(int id)
        {
            var entity = _coachrepository.GetById(id);
            _coachrepository.Delete(entity);
        }

        public CoachAddEditVM GetById(int id)
        {
            var entity = _coachrepository.GetById(id);
            return new CoachAddEditVM
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                DOB = entity.DOB,
                ClubId = entity.ClubId,
            };
        }

        public void Update(CoachAddEditVM Coach)
        {
            var entity = _coachrepository.GetById(Coach.Id);
            entity.FirstName = Coach.FirstName;
            entity.LastName = Coach.LastName;
            entity.DOB = Coach.DOB;
            entity.ClubId = Coach.ClubId;
        }
    }
}
