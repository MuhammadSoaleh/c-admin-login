using ecommerce.Models;

namespace ecommerce
{
    public interface IHomeRepository
    {
         Task<IEnumerable<Book>> DisplayBooks(string sTerm, int categoryId = 0);
    }
}