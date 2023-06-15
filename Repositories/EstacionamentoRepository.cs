using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using estacionamento.Models;
using estacionamento.context;
using estacionamento.Repositories.Interfaces;

namespace estacionamento.Repositories
{
    public class EstacionamentoRepository : IEstacionamentoRepository
    {
         private readonly EstacionamentoContext _estacionamentoContext;

        public EstacionamentoRepository(EstacionamentoContext estaciomanetoContext){
            _estacionamentoContext = estaciomanetoContext;
        }

        public void Create(Estacionamento entity)
        {
            _estacionamentoContext.Add(entity);
            
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Estacionamento> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Estacionamento> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Estacionamento entity)
        {
            throw new NotImplementedException();
        }
    }
}