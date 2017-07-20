using System.Collections.Generic;

namespace Aspnetcore.Pieshop.Webapp.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> Pies { get; }
    }
}