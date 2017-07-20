using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aspnetcore.Pieshop.Webapp.Models;
using Aspnetcore.Pieshop.Webapp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Aspnetcore.Pieshop.Webapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly IPieRepository _categoryRepository;

        public HomeController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = pieRepository;
        }

        public IActionResult Index()
        {
            PieListViewModel pieListViewModel = new PieListViewModel
            {
                Pies = _pieRepository.Pies,
                CurrentCategory = "Cheese cakes"
            };

            return View(pieListViewModel);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}