namespace ecommerce.Models
{
    public class CartDetails
    {
        public int Id { get; set; }
        public int ShoppindCartId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public Book book { get; set; }
        public ShoppingCart shoppingCart { get; set; }
    }
}
