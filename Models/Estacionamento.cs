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
        public double ValorHora { get; private set; }
        public double ValorTaxaInicial { get; private set; }
        public int TempoPadrao { get; private set; }
        public int TempoTolerancia { get; private set; }
        
        public Estacionamento(int capacidade, double valorHora, double valorTaxaInicial, int tempoPadrao, int tempoTolerancia, string nome = "Não Informado"){
            Nome = nome;
            Capacidade = capacidade > 1 ? capacidade : 1;
            ValorHora = valorHora > 1 ? valorHora : 1.0;
            ValorTaxaInicial = valorTaxaInicial > 1 ? valorTaxaInicial : 1.0;
            TempoPadrao = tempoPadrao > 1 ? tempoPadrao : 1;
            TempoTolerancia = tempoTolerancia > 1 ? tempoTolerancia : 1;
        }

        public void AtualizarCapacidade(int novaCapacidade = 1){
            Capacidade = novaCapacidade > 1 ? novaCapacidade : 1;
            UpdateAt = DateTime.Now;
        }

        public void AtualizarDescricao(string novaDescricao){
            Nome = novaDescricao;
            UpdateAt = DateTime.Now;
        }
        public void AtualizarValorHora(double novoValorHora = 1){            
            ValorHora = novoValorHora > 1 ? novoValorHora : 1;
            UpdateAt = DateTime.Now;
        }

        public void AtualizarValorTaxaInicial(double novoValorTaxaInicial = 1){            
            ValorTaxaInicial = novoValorTaxaInicial > 1 ? novoValorTaxaInicial : 1;
            UpdateAt = DateTime.Now;
        }
        public void AtualizarTolerancia(int novoTempoTolerancia = 1){            
            TempoTolerancia = novoTempoTolerancia > 1 ? novoTempoTolerancia : 1;
            UpdateAt = DateTime.Now;
        }
    }
}