using Application.DTO;
using Application.Interfaces;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Application.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private readonly IBookService _bookService;
        public MainViewModel(IBookService bookService)
        {
            _bookService = bookService;
            BookCreateRequest = new BookCreateRequestDto() { Author = "Автор", Title = "Название" };
            Books = new ObservableCollection<BookDto>(_bookService.GetAll());
        }
        public ICommand AddBook => new DelegateCommand(() =>
        {
            Books.Add(_bookService.Create(BookCreateRequest));
        });
        public BookCreateRequestDto BookCreateRequest { get; set; }
        public DateTime Time => DateTime.Now;

        public ObservableCollection<BookDto> Books { get; set; }

        private BookDto _bookDto;
        public BookDto SelectedBook { get => _bookDto; set { _bookDto = value; RaisePropertyChanged(); } }
    }
}
