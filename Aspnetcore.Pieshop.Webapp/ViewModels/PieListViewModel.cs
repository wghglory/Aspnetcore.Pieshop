using System.Collections.Generic;
using Aspnetcore.Pieshop.Webapp.Models;

namespace Aspnetcore.Pieshop.Webapp.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}