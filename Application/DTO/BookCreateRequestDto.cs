using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTO
{
    public class BookCreateRequestDto : IDtoMapper<Book>
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book ToModel()
        {
            return new Book() { Title = this.Title, YearOfPublishing = DateTime.Now };
        }
    }
}
