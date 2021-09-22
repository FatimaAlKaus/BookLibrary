using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IDtoMapper<T> where T : class
    {
        T ToModel();
    }
}
