using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using estacionamento.Repositories;
using estacionamento.Models;
using estacionamento.Repositories.Interfaces;

namespace estacionamento.Repositories
{
    public class ReservaRepository : IBaseRepository<Reserva>
    {
        public void Create(Reserva entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reserva> GetAll()
        {
            throw new NotImplementedException();
        }

        public Reserva GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Reserva entity)
        {
            throw new NotImplementedException();
        }
    }
}