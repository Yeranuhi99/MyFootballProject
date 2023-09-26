using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFootballProject.Services;
using MyFootballProject.Services.Interfaces;
using MyFootballProject.ViewModels;

namespace MyFootballProject.Controllers
{
    public class StadiumController : Controller
    {
        private readonly IStadiumService _stadiumService;
        public StadiumController(IStadiumService stadiumService)
        {
            _stadiumService = stadiumService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddEdit(int? id)
        {
            StadiumAddEditVM model = id.HasValue ?
                _stadiumService.GetById(id.Value) :
                new StadiumAddEditVM(); 
            return View(model);
        }

        [HttpPost]
        public IActionResult AddEdit(StadiumAddEditVM club)
        {
            if (club.Id == 0)
            {
                _stadiumService.Add(club);
            }
            else
            {
                _stadiumService.Update(club);
            }
            return RedirectToAction(nameof(StadiumIndex));
        }
        public IActionResult Delete(int Id)
        { 
             _stadiumService.Delete(Id);
            return RedirectToAction(nameof(StadiumIndex));
        }
        public IActionResult StadiumIndex()
        {
            var stadiums = _stadiumService.GetAll();
            return View(stadiums);
        }
    }
}
