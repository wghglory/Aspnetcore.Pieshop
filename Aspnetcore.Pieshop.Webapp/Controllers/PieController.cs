using System.Collections.Generic;
using System.Linq;
using Aspnetcore.Pieshop.Webapp.Models;
using Aspnetcore.Pieshop.Webapp.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace Aspnetcore.Pieshop.Webapp.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

/*        public ViewResult List()
        {
            PieListViewModel pieListViewModel = new PieListViewModel
            {
                Pies = _pieRepository.Pies,
                CurrentCategory = "Cheese cakes"
            };

            return View(pieListViewModel);
        }*/

        public ViewResult List(string category)
        {
            IEnumerable<Pie> pies;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                pies = _pieRepository.Pies.OrderBy(p => p.Id);
                currentCategory = "All pies";
            }
            else
            {
                pies = _pieRepository.Pies.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.Id);
                currentCategory = _categoryRepository.Categories.FirstOrDefault(c => c.CategoryName == category)
                    ?.CategoryName;
            }

            return View(new PieListViewModel
            {
                Pies = pies,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();

            return View(pie);
        }
    }
}