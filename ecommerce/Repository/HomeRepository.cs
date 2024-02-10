using ecommerce.Data;
using ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Repository
{
    public class HomeRepository:IHomeRepository
    {
        private readonly ApplicationDbContext db;

        public HomeRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public async Task<IEnumerable<Book>> DisplayBooks(string sTerm, int categoryId = 0)
        {
            IEnumerable<Book> books =await (
      from book in db.Books
      join category in db.Categories on book.CategoryId equals category.Id
      where string.IsNullOrWhiteSpace(sTerm) ||
            (sTerm != null && book.BookName.ToLower().StartsWith(sTerm.ToLower()))
      select new Book
      {
          // Assuming Book has properties like BookName, Author, etc.
          BookName = book.BookName,
          Id = book.Id,
          Price = book.Price,
          Image = book.Image,
          Author = book.Author,
          CategoryId = book.CategoryId,
          CategoryName = book.CategoryName,
          // Include other properties as needed
      }
  ).ToListAsync();
            if (categoryId > 0)
            {
                books = books.Where(a => a.CategoryId == categoryId).ToList();
            }
            return books;
        }
    }
}
