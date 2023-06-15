using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using estacionamento.Models;
using Microsoft.EntityFrameworkCore;

namespace estacionamento.context
{
    public class EstacionamentoContext : DbContext
    {
        public DbSet<Estacionamento> Estacionamento { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public string DbPath { get; }
        public EstacionamentoContext()
        {
            var path = Environment.CurrentDirectory;
            DbPath = Path.Join(path, "db/estacionamento.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}