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
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public double ValorTotal { get; set; }
        public StatusReserva Status { get; set; }
    }
}

