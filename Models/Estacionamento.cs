using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento.Models
{
    public class Estacionamento : Base<int>
    { 
        public string Nome { get; private set; }
        public int Capacidade { get; private set; }
        public double ValorHora {get; private set; }
        public double ValorInicial {get; private set; }
        public double TempoInicial {get; private set; }
        
        public Estacionamento(int capacidade, double valorHora, double valorInicial, double tempoInicial, string nome = "Não Informado"){
            Nome = nome;
            Capacidade = capacidade > 0 ? capacidade : 1;
            ValorHora = valorHora > 0 ? valorHora : 1.0;
            ValorInicial = valorInicial > 0 ? valorInicial : 1.0;
            TempoInicial = tempoInicial > 0 ? tempoInicial : 1.0;
        }

        public void AtualizarCapacidade(int capacidade = 1){
            Capacidade = capacidade > 0 ? capacidade : 1;
            UpdateAt = DateTime.Now;
        }
        public void AtualizarValorHora(double valorHora = 1){            
            ValorHora = valorHora > 0 ? valorHora : 1;
            UpdateAt = DateTime.Now;
        }

    }
}