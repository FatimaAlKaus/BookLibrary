using Application.DTO;
using Application.Interfaces;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Application.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private readonly IBookService _bookService;
        public MainViewModel(IBookService bookService)
        {
            _bookService = bookService;
            Books = new ObservableCollection<BookDto>(_bookService.GetAll());
        }

        public ObservableCollection<BookDto> Books { get; set; }

        private BookDto _bookDto;
        public BookDto SelectedBook { get => _bookDto; set { _bookDto = value; RaisePropertyChanged(); } }
    }
}
