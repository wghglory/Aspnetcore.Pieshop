using Aspnetcore.Pieshop.Webapp.Models;
using Aspnetcore.Pieshop.Webapp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Aspnetcore.Pieshop.Webapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheWeek = _pieRepository.PiesOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}