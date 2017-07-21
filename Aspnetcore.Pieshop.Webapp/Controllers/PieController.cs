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

        public ViewResult List()
        {
            PieListViewModel pieListViewModel = new PieListViewModel
            {
                Pies = _pieRepository.Pies,
                CurrentCategory = "Cheese cakes"
            };

            return View(pieListViewModel);
        }
        
    }
}
