using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using MyFootballProject.Data.Repositories.Interfaces;

namespace MyFootballProject.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FootballDataContext _context;
        public UnitOfWork(FootballDataContext context)
        {
                _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
