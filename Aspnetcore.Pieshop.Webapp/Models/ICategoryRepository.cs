using System.Collections.Generic;

namespace Aspnetcore.Pieshop.Webapp.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}