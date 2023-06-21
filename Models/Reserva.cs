using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using estacionamento.Enum;

namespace estacionamento.Models
{
    public class Reserva : Base<int>
    {
        public virtual Estacionamento Estacionamento {get; set;}
        public virtual Veiculo Veiculo {get; set;} 
        public DateTime DataEntrada { get; private set ; }
        public DateTime? DataSaida { get; private set ; }
        public double? ValorTotal { get; private set; }
        public StatusReserva Status { get; private set; }
        public FormaPagamento? FormaPagamento { get; private set; }

        public Reserva(){
            Status = StatusReserva.Ocupada;
            DataEntrada = DateTime.Now;
        }

        public void Cancelar(){
            Status = StatusReserva.Disponivel;
            Ativo = false;
            UpdateAt = DateTime.Now;
        }

        public void AtualizarDataEntrada(DateTime novaDataEntrada){
            DataEntrada = novaDataEntrada;
            UpdateAt = DateTime.Now;
        }

         public void AtualizarFormaPagamento(FormaPagamento formaPagamento){
            FormaPagamento = formaPagamento;
            UpdateAt = DateTime.Now;
        }

        public void Encerrar(DateTime dataEncerramento){
            Status = StatusReserva.Encerrada;
            DataSaida = dataEncerramento;

            CalcularValorTotal(3);
        }

        private void CalcularValorTotal(int tempoMinimo){
            //double tempoTotal = DataSaida - DataEntrada;
        }
    }
}

