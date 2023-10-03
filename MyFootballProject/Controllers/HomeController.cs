using Microsoft.AspNetCore.Mvc;
using MyFootballProject.Models;
using MyFootballProject.Services;
using MyFootballProject.Services.Interfaces;
using System.Diagnostics;

namespace MyFootballProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IClubService _clubservice;
        private readonly IPlayerService _playerservice;

        public HomeController(ILogger<HomeController> logger, IPlayerService playerservice, IClubService clubService)
        {
            _logger = logger;
            _playerservice = playerservice;
            _clubservice = clubService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetStarted()
        {
            return View();
        }
        public IActionResult PlayersList()
        {
            var players = _playerservice.GetAll();
            return View(players);
        }
        public IActionResult ClubsList()
        {
            var clubs = _clubservice.GetAll();
            return View(clubs);
        }
        public IActionResult Profile(int id)
        {
            ViewBag.Clubdropdown = _clubservice.GetListForDropdown();
            var player = _playerservice.GetById(id);
         
            return View(player);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}