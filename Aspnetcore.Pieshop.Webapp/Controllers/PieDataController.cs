using System.Collections.Generic;
using System.Linq;
using Aspnetcore.Pieshop.Webapp.Models;
using Aspnetcore.Pieshop.Webapp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Aspnetcore.Pieshop.Webapp.Controllers
{
    [Route("api/[controller]")]
    public class PieDataController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public PieDataController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IEnumerable<PieViewModel> Get()
        {
            IEnumerable<Pie> dbPies = null;

            dbPies = _pieRepository.Pies.OrderBy(p => p.Id).Take(10);

            List<PieViewModel> pies = new List<PieViewModel>();

            foreach (var dbPie in dbPies)
            {
                pies.Add(MapDbPieToPieViewModel(dbPie));
            }
            return pies;
        }

        private static PieViewModel MapDbPieToPieViewModel(Pie dbPie)
        {
            return new PieViewModel()
            {
                PieId = dbPie.Id,
                Name = dbPie.Name,
                Price = dbPie.Price,
                ShortDescription = dbPie.ShortDescription,
                ImageThumbnailUrl = dbPie.ImageThumbnailUrl
            };
        }
    }
}