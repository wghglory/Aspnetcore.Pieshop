using System.Collections.Generic;
using Aspnetcore.Pieshop.Webapp.Models;

namespace Aspnetcore.Pieshop.Webapp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
