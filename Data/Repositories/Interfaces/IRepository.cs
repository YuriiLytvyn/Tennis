using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Interfaces
{
    public interface IRepository<T, K>
    {
        void Create(T t);
        void Update(T t);
        T GetById(K id);
        void DeleteById(K id);
        IEnumerable<T> GetAll();
    }
}
