using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using estacionamento.Enum;

namespace estacionamento.Models
{
    public class Veiculo : Base<int>
    {
        public string Placa { get; private set; }
        public TipoVeiculo Tipo { get; private set; }
        public string NomeProprietario {get; private set;}
        public string DocumentoProprietario {get; private set; }

        public Veiculo(string placa, TipoVeiculo tipo, string nomeProprietario, string documentoProprietario){
            Placa = placa;
            Tipo = tipo;
            NomeProprietario = nomeProprietario;
            DocumentoProprietario = documentoProprietario;
        }

        public void AtualizaPlaca(string newPlaca){
            Placa = newPlaca.Replace("-", "");
        }

        public void AtualizaTipoVeiculo(TipoVeiculo tipoVeiculo){
            Tipo = tipoVeiculo;
        }

        public void AtualizaNomeProprietario(string nomeProprietario){
            NomeProprietario = nomeProprietario;
        }

        public void AtualizaDocumentoProprietario(string documentoProprietario){
            DocumentoProprietario = documentoProprietario;
        }


    }
}