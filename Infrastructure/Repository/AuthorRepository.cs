using Domain.Models;
using Domain.Repository;
using Infrastructure.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private DatabaseContext _context;
        public AuthorRepository(DatabaseContext databaseContext)
        {
            _context = databaseContext;
        }
        public Author Create(Author entity)
        {
            var author = _context.Authors.Add(entity);
            _context.SaveChanges();
            return author.Entity;

        }

        public void Delete(int id)
        {
            var author = _context.Authors.FirstOrDefault(author => author.Id == id);
            _context.Authors.Remove(author);
            _context.SaveChanges();
        }

        public Author Get(int id)
        {
            return _context.Authors.FirstOrDefault(author => author.Id == id);
        }

        public IQueryable<Author> GetAll()
        {
            return _context.Authors.AsNoTracking();
        }

        public Author Update(Author entity)
        {
            var author = _context.Authors.Update(entity);
            _context.SaveChanges();
            return author.Entity;
        }
        public Author GetByName(string name)
        {
            return _context.Authors.FirstOrDefault(author => author.Name.ToLower() == name.ToLower());
        }
    }
}
