namespace ecommerce.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public bool IsDeleted { get; set; }=false;
    }
}
