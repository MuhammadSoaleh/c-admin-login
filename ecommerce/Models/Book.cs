using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }
        public Category Category;
        public int CategoryId { get; set; }
        [NotMapped]
        public string CategoryName { get; set; }
        public List<OrderDetails> orderDetails { get; set;}
        public List<CartDetails> CartDetails  { get; set;}
    }
}
