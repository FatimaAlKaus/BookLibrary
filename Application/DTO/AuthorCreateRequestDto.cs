using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTO
{
    public class AuthorCreateRequestDto : IDtoMapper<Author>
    {
        public string Name { get; set; }
        public Author ToModel()
        {
            return new Author() { Name = this.Name };
        }
    }
}
