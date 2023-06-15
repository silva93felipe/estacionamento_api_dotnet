using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using estacionamento.Enum;

namespace estacionamento.Models
{
    public class Veiculo : Base<int>
    {
        public string Placa { get; set; }
        public TipoVeiculo Tipo { get; set; }
        public string NomeProprietario {get; set;}
        public string DocumentoProprietario {get; set; }

    }
}