using AMSLibrary.Entities;
using System.Collections.Generic;

namespace AMSLibrary.DataAccess
{
    interface IGenericAccess<T> where T : IHasId
    {
        void Create(T entity, bool orderById);
        List<T> Get(out int nextId);
        T GetById(string id);
        void Update(T entity);
        void Delete(string id);
    }
}
