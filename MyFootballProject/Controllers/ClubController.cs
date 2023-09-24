using Microsoft.AspNetCore.Mvc;
using MyFootballProject.Data.Repositories.Interfaces;
using MyFootballProject.Services;
using MyFootballProject.Services.Interfaces;
using MyFootballProject.ViewModels;

namespace MyFootballProject.Controllers
{
    public class ClubController : Controller
    {
        private readonly IClubService _clubservice;
        public ClubController(IClubService clubservice)
        {
            _clubservice = clubservice;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddEdit(int? id)
        {
            ClubAddEditVM model = id.HasValue ?
                _clubservice.GetById(id.Value) :
                new ClubAddEditVM();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddEdit(ClubAddEditVM club)
        {
            if (club.Id == 0)
            {
                _clubservice.Add(club);
            }
            else
            {
                _clubservice.Update(club);
            }
            return View();
        }
    }
}
