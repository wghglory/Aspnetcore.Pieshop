namespace Aspnetcore.Pieshop.Webapp.Models
{
    // each order detail correspond to 1 pie
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int PieId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Pie Pie { get; set; }
        public virtual Order Order { get; set; }
    }
}