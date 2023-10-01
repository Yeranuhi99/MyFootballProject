using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyFootballProject.Data.Repositories.Interfaces;
using MyFootballProject.Services;
using MyFootballProject.Services.Interfaces;
using MyFootballProject.ViewModels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MyFootballProject.Controllers
{
    public class ClubController : Controller
    {
        private readonly IClubService _clubservice;
        private readonly IStadiumService _stadiumservice;
        private readonly IPresidentService _presidentservice;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IUnitOfWork _unitOfWork;
        public ClubController(IClubService clubservice, IStadiumService stadiumservice, IPresidentService presidentservice, IWebHostEnvironment webHostEnvironment, IUnitOfWork unitOfWork)
        {
            _clubservice = clubservice;
            _stadiumservice = stadiumservice;
            _presidentservice = presidentservice;
            _webHostEnvironment = webHostEnvironment;
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddEdit(int? id)
        {
            ViewBag.StadiumDropDown = _stadiumservice.GetListForDropdown();
            ViewBag.PresidentDropDown = _presidentservice.GetListForDropdown();
            ClubAddEditVM model = id.HasValue ?
                _clubservice.GetById(id.Value) :
                new ClubAddEditVM();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddEdit(ClubAddEditVM club, IFormFile Image)
        {
            if (Image != null)
            {
                string path = "/Images/" + Image.FileName;
                using (var fileStream = new FileStream(_webHostEnvironment.WebRootPath + path, FileMode.Create)) { Image.CopyTo(fileStream); }
                club.FileName = path;
            }
            if (club.Id == 0)
            {
                _clubservice.Add(club);
            }
            else
            {
                _clubservice.Update(club);
            }
            return RedirectToAction(nameof(List));
        }
        public IActionResult List()
        {
            var clubs = _clubservice.GetAll();
            return View(clubs);
        }
        public IActionResult Delete(int id)
        {
            _clubservice.Delete(id);
            return RedirectToAction(nameof(List));
        }
    }
}
