using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using estacionamento.Models;
using Microsoft.EntityFrameworkCore;
using estacionamento.Enum;

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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>()
                        .Property(e => e.Ativo).HasDefaultValue("true");
            modelBuilder.Entity<Veiculo>()
                        .Property(e => e.Tipo).HasDefaultValue(TipoVeiculo.Carro);
            modelBuilder.Entity<Veiculo>()
                        .Property(e => e.NomeProprietario).HasMaxLength(30).HasColumnType("VARCHAR");
            modelBuilder.Entity<Veiculo>()
                        .Property(e => e.Placa).HasMaxLength(7).HasColumnType("VARCHAR");
            modelBuilder.Entity<Veiculo>()
                        .Property(e => e.DocumentoProprietario).HasMaxLength(20).HasColumnType("VARCHAR");
            modelBuilder.Entity<Veiculo>()
                        .Property(e => e.UpdateAt).HasDefaultValue(DateTime.UtcNow);
            modelBuilder.Entity<Veiculo>()
                        .Property(e => e.CreatAt).HasDefaultValue(DateTime.UtcNow);


            modelBuilder.Entity<Estacionamento>()
                        .Property(e => e.Ativo).HasDefaultValue("true");
            modelBuilder.Entity<Estacionamento>()
                        .Property(e => e.Nome).HasMaxLength(50);
            modelBuilder.Entity<Estacionamento>()
                        .Property(e => e.UpdateAt).HasDefaultValue(DateTime.UtcNow);
            modelBuilder.Entity<Estacionamento>()
                        .Property(e => e.CreatAt).HasDefaultValue(DateTime.UtcNow);
        
        
            modelBuilder.Entity<Reserva>()
                                    .Property(e => e.Ativo).HasDefaultValue("true");
            modelBuilder.Entity<Reserva>()
                        .Property(e => e.UpdateAt).HasDefaultValue(DateTime.UtcNow);
            modelBuilder.Entity<Reserva>()
                        .Property(e => e.CreatAt).HasDefaultValue(DateTime.UtcNow);

        }
        
    }
}