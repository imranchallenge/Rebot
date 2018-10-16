using System;
using System.Collections.Generic;
using System.Text;

namespace Rebot.Core
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Save();
    }
}
