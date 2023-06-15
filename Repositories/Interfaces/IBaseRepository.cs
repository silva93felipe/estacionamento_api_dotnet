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
        Task<T> GetById(int id);
        void Update(T entity);
        Task<bool> Delete(int id);
        bool SaveChanges();
        
    }
}