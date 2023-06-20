using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();
        void Create(T entity);
        T GetById(int id);
        void Update(int id, T entity);
        void Delete(int id);
        void SaveChanges();
        
    }
}