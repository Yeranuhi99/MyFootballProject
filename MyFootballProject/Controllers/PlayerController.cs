using Microsoft.AspNetCore.Mvc;
using MyFootballProject.Services;
using MyFootballProject.Services.Interfaces;
using MyFootballProject.ViewModels;

namespace MyFootballProject.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerService _playerService;
        private readonly IClubService _clubService;
        public PlayerController(IPlayerService playerService, IClubService clubService)
        {
                _playerService = playerService;
                _clubService = clubService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddEdit(int? id)
        {
            ViewBag.Clubdropdown = _clubService.GetListForDropdown();
            PlayerAddEditVM model = id.HasValue ?
                _playerService.GetById(id.Value) :
                new PlayerAddEditVM();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddEdit(PlayerAddEditVM club)
        {
            if (club.Id == 0)
            {
                _playerService.Add(club);
            }
            else
            {
                _playerService.Update(club);
            }
            return RedirectToAction(nameof(List));
        }
        public IActionResult List()
        {
            var players = _playerService.GetAll();
            return View(players);
        }
        public IActionResult Delete(int id)
        {
            _playerService.Delete(id);
            return RedirectToAction(nameof(List));
        }
    }
}
