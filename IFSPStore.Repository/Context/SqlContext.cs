
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace IFSPStore.Repository.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

            Database.EnsureCreated(); // Cria o banco caso não exista

        }

        public DbSet<Passageiro> Passageiros { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Viagem> Viagens { get; set; }
        public DbSet<Onibus> Onibus { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Assento> Assentos { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Passageiro>(new PassageiroMap().Configure);
            modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
            modelBuilder.Entity<Viagem>(new ViagemMap().Configure);
            modelBuilder.Entity<Onibus>(new OnibusMap().Configure);
            modelBuilder.Entity<Reserva>(new ReservaMap().Configure);
            modelBuilder.Entity<Assento>(new AssentoMap().Configure);
        }
    }
}
