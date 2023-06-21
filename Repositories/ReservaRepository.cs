using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using estacionamento.Repositories;
using estacionamento.Models;
using estacionamento.Repositories.Interfaces;
using estacionamento.context;

namespace estacionamento.Repositories
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly EstacionamentoContext _estacionamentoContext;

        public ReservaRepository(EstacionamentoContext estacionamentoContext)
        {
            _estacionamentoContext = estacionamentoContext;
        }

        public void Create(Reserva entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var reserva = _estacionamentoContext.Reservas.Where(r => r.Id == id).SingleOrDefault();

            if(reserva != null){
                reserva.Cancelar();
            }

            SaveChanges();
        }

        public IEnumerable<Reserva> GetAll()
        {
            return _estacionamentoContext.Reservas;
        }

        public Reserva? GetById(int id)
        {
            return _estacionamentoContext.Reservas.Where(r => r.Id == id).SingleOrDefault();
        }

        public void SaveChanges()
        {
            _estacionamentoContext.SaveChanges();
        }

        public void Update(int id, Reserva entity)
        {
            throw new NotImplementedException();
        }
    }
}