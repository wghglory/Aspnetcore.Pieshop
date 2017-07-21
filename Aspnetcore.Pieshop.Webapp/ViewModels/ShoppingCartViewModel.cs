using Aspnetcore.Pieshop.Webapp.Models;

namespace Aspnetcore.Pieshop.Webapp.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
    }
}