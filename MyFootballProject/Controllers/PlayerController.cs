using Microsoft.AspNetCore.Mvc;
using MyFootballProject.Data.Repositories.Interfaces;
using MyFootballProject.Services;
using MyFootballProject.Services.Interfaces;
using MyFootballProject.ViewModels;

namespace MyFootballProject.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerService _playerService;
        private readonly IClubService _clubService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IUnitOfWork _unitOfWork;
        public PlayerController(IPlayerService playerService, IClubService clubService, IWebHostEnvironment webHostEnvironment, IUnitOfWork unitOfWork)
        {
            _playerService = playerService;
            _clubService = clubService;
            _webHostEnvironment = webHostEnvironment;
            _unitOfWork = unitOfWork;
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
        public IActionResult AddEdit(PlayerAddEditVM player, IFormFile Image)
        {
            if (Image != null)
            {
                string path = "/PlayerImages/" + Image.FileName;
                using (var fileStream = new FileStream(_webHostEnvironment.WebRootPath + path, FileMode.Create)) { Image.CopyTo(fileStream); }
                player.ImageName = path;
            }
            if (player.Id == 0)
            {
                _playerService.Add(player);
            }
            else
            {
                _playerService.Update(player);
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
