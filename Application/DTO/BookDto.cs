using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Application.DTO
{
    public class BookDto
    {
        public BookDto(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            Author = book.Author.Name;
            PublishingDate = book.YearOfPublishing.Date;
        }
        public int Id { get; }
        public string Title { get; }
        public string Author { get; }
        public DateTime PublishingDate { get; }
    }
}
