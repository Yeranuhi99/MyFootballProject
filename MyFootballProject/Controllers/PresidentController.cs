using Microsoft.AspNetCore.Mvc;
using MyFootballProject.Services;
using MyFootballProject.Services.Interfaces;
using MyFootballProject.ViewModels;
using System.Security.Cryptography.Pkcs;

namespace MyFootballProject.Controllers
{
    public class PresidentController : Controller
    {
        private readonly IPresidentService _presidentservice;
        public PresidentController(IPresidentService presidentservice)
        {
            _presidentservice = presidentservice;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddEdit(int? id)
        {
            PresidentAddEditVM model = id.HasValue ?
                _presidentservice.GetById(id.Value) :
                new PresidentAddEditVM();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddEdit(PresidentAddEditVM president)
        {
            if (president.Id == 0)
            {
                _presidentservice.Add(president);
            }
            else
            {
                _presidentservice.Update(president);
            }
            return RedirectToAction(nameof(List));
        }
        public IActionResult List()
        {
            var presidents = _presidentservice.GetAll();
            return View(presidents);
        }
        public IActionResult Delete(int id)
        {
            _presidentservice.GetById(id);
            return RedirectToAction(nameof(List));
        }
    }
}
