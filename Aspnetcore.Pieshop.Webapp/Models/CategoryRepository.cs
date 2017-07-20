using System.Collections.Generic;

namespace Aspnetcore.Pieshop.Webapp.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> Categories => _appDbContext.Categories;

        /*public IEnumerable<Category> Categories => new List<Category>
        {
            new Category {Id = 1, CategoryName = "Fruit pies", Description = "All-fruity pies"},
            new Category {Id = 2, CategoryName = "Cheese cakes", Description = "Cheesy all the way"},
            new Category {Id = 3, CategoryName = "Seasonal pies", Description = "Get in the mood for a seasonal pie"}
        };*/
    }
}