using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public Edition Edition { get; set; }
        public DateTime YearOfPublishing { get; set; }
    }
}
