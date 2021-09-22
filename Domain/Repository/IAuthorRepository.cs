using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Repository
{
    public interface IAuthorRepository : IBaseRepository<Author>
    {
        Author GetByName(string name);
    }
}
