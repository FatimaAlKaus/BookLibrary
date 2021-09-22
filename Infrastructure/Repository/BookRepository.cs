using Domain.Models;
using Domain.Repository;
using Infrastructure.EF;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infrastructure.Repository
{
    public class BookRepository : IBookRepository
    {
        private DatabaseContext _context;
        public BookRepository(DatabaseContext context)
        {
            _context = context;
        }

        public Book Create(Book book)
        {
            var entity = _context.Books.Add(book);
            _context.SaveChanges();
            return entity.Entity;
        }

        public void Delete(int id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public Book Get(int id)
        {
            return _context.Books.Include(b => b.Author).FirstOrDefault(b => b.Id == id);

        }

        public IQueryable<Book> GetAll()
        {
            return _context.Books.Include(b => b.Author).AsNoTracking();
        }


        public Book Update(Book entity)
        {
            var book = _context.Update(entity);
            _context.SaveChanges();
            return book.Entity;
        }
    }
}
