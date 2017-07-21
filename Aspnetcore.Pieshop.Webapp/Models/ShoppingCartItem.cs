namespace Aspnetcore.Pieshop.Webapp.Models
{
    // each item in shopping cart
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public Pie Pie { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }  //store session id
        // better way is to use database to record shoppingcart for users, but here is just a easy demo
    }
}