using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using estacionamento.Models;
using estacionamento.Repositories.Interfaces;


namespace estacionamento.Repositories
{
    public class VeiculoRepository : IBaseRepository<Veiculo>
    {
        public void Create(Veiculo entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Veiculo> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Veiculo> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Veiculo entity)
        {
            throw new NotImplementedException();
        }
    }
}