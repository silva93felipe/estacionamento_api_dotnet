using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using estacionamento.Models;
using estacionamento.Repositories.Interfaces;
using estacionamento.context;


namespace estacionamento.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly EstacionamentoContext _estacionamentoContext;

        public VeiculoRepository(EstacionamentoContext estacionamentoContext)
        {
            _estacionamentoContext = estacionamentoContext;
        }

        public void Create(Veiculo entity)
        {
            _estacionamentoContext.Add(entity);

            SaveChanges();
        }

        public void Delete(int id)
        {
            var veiculo = _estacionamentoContext.Veiculos.SingleOrDefault(x => x.Id == id);

            if(veiculo != null){
                veiculo.Ativo = false;
                veiculo.UpdateAt = DateTime.Now;

                SaveChanges();
            }
        }

        public IEnumerable<Veiculo> GetAll()
        {
            return _estacionamentoContext.Veiculos;
        }

        public Veiculo? GetById(int id)
        {
            return _estacionamentoContext.Veiculos.SingleOrDefault(x => x.Id == id);
        }

        public void SaveChanges()
        {
            _estacionamentoContext.SaveChanges();
        }

        public void Update(int id, Veiculo entity)
        {
            var veiculo = GetById(id);

            if(veiculo != null){
                veiculo.AtualizaPlaca(entity.Placa);
                veiculo.AtualizaDocumentoProprietario(entity.DocumentoProprietario);
                veiculo.AtualizaNomeProprietario(entity.NomeProprietario);
                veiculo.AtualizaTipoVeiculo(entity.Tipo);
                veiculo.UpdateAt = DateTime.Now;

                SaveChanges();
            }
        }
    }
}