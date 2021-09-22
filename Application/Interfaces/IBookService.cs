using Application.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Application.Interfaces
{
    public interface IBookService
    {
        BookDto GetBookById(int id);
        BookDto Create(BookCreateRequestDto book);
        BookDto[] GetAll();
    }
}
