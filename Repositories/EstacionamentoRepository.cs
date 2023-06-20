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
            SaveChanges();
        }

        public void Delete(int id)
        {
            var estacionamento = _estacionamentoContext.Estacionamento.FirstOrDefault(x => x.Id == id);
            if(estacionamento != null){
                estacionamento.Ativo  = false;
                estacionamento.UpdateAt = DateTime.Now;
            }

            SaveChanges();

        }

        public IEnumerable<Estacionamento> GetAll()
        {
            return _estacionamentoContext.Estacionamento.Where(e => e.Ativo);
        }

        public Estacionamento? GetById(int id)
        {
            return  _estacionamentoContext.Estacionamento.FirstOrDefault(e => e.Id == id);            
        } 

        public void SaveChanges()
        {
            _estacionamentoContext.SaveChanges();
        }

        public void Update(int id, Estacionamento entity)
        {
            
            var estacionamentoDb =  GetById(id);

            if(estacionamentoDb != null){
                estacionamentoDb.AtualizarCapacidade(entity.Capacidade);
                estacionamentoDb.AtualizarDescricao(entity.Nome);
                estacionamentoDb.AtualizarTolerancia(entity.TempoTolerancia);
                estacionamentoDb.AtualizarValorHora(entity.ValorHora);
                estacionamentoDb.AtualizarValorTaxaInicial(entity.ValorTaxaInicial);
            }

            SaveChanges();
        }
    }
}