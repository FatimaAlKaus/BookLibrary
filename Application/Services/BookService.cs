using Application.DTO;
using Application.Interfaces;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Application.Services
{
    public class BookService : IBookService
    {
        private IBookRepository _bookRepository;
        private IAuthorRepository _authorRepository;
        public BookService(IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
        }

        public BookDto Create(BookCreateRequestDto book)
        {
            var model = book.ToModel();
            var author = _authorRepository.GetByName(book.Author);
            if (author == null)
            {
                var new_author = _authorRepository.Create(new AuthorCreateRequestDto() { Name = book.Author }.ToModel());
                model.Author = new_author;
            }
            else
            {
                model.Author = author;
            }

            return new BookDto(_bookRepository.Create(model));
        }

        public BookDto[] GetAll()
        {
            return _bookRepository.GetAll().Select(b => new BookDto(b)).ToArray();

        }

        public BookDto GetBookById(int id)
        {
            return new BookDto(_bookRepository.Get(id));
        }
    }
}
