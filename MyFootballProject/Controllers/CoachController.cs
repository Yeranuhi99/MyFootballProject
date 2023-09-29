using Microsoft.AspNetCore.Mvc;
using MyFootballProject.Services;
using MyFootballProject.Services.Interfaces;
using MyFootballProject.ViewModels;

namespace MyFootballProject.Controllers
{
    public class CoachController : Controller
    {
        private readonly ICoachService _coachservice;
        private readonly IClubService _clubservice;
        public CoachController(ICoachService coachservice, IClubService clubservice)
        {
            _coachservice= coachservice;
            _clubservice = clubservice;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddEdit(int? id)
        {
            ViewBag.Clubdropdown = _clubservice.GetListForDropdown();
            CoachAddEditVM model = id.HasValue ?
                _coachservice.GetById(id.Value) :
                new CoachAddEditVM();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddEdit(CoachAddEditVM coach)
        {
            if (coach.Id == 0)
            {
                _coachservice.Add(coach);
            }
            else
            {
                _coachservice.Update(coach);
            }
            return RedirectToAction(nameof(List));
        }
        public IActionResult List()
        {
            var coaches = _coachservice.GetAll();
            return View(coaches);
        }
        public IActionResult Delete(int id)
        {
            _coachservice.Delete(id);
            return RedirectToAction(nameof(List));
        }
    }
}

