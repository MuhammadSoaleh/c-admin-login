namespace ecommerce.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDate { get; set; }=DateTime.Now;
        public bool IsDeleted { get; set; }=false;
       public OrderStatus OrderStatus { get; set; }
       public List<OrderDetails> OrderDetails { get; set; }
    }
}
