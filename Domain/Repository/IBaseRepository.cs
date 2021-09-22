using System;
using System.Text;
using System.Linq;

namespace Domain.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        T Create(T entity);
        T Get(int id);
        IQueryable<T> GetAll();
        T Update(T entity);
        void Delete(int id);
    }
}
