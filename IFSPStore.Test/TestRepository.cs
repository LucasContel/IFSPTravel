using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Test
{
    [TestClass]
    public class TestRepository
    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Onibus> Onibus { get; set; }
            public DbSet<Assento> Assentos { get; set; }
            public DbSet<Cidade> Cidades { get; set; }
            public DbSet<Viagem> Viagens { get; set; }
            public DbSet<Reserva> Reservas { get; set; }
            public DbSet<Passageiro> Passageiros { get; set; }
            public MyDbContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "IFSPTravel";
                var username = "root";
                var password = "ifsp";
                var strCon = $"Server={server};Port={port};Database={database};" +
                    $"Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }
        }

        [TestMethod]
        public void TestInsertCidades()
        {

            using (var context = new MyDbContext())
            {


                var cidade = new Cidade
                {
                    Nome = "Birigui",
                    Estado = "SP"
                };

                context.Cidades.Add(cidade);

                cidade = new Cidade
                {
                    Nome = "Araçatuba",
                    Estado = "SP"
                };
                context.Cidades.Add(cidade);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListCidades()
        {
            using (var context = new MyDbContext())
            {
                foreach (var cidade in context.Cidades)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cidade));
                }
            }
        }

        [TestMethod]
        public void TestInsertPassageiros()
        {
            using (var context = new MyDbContext())
            {

                var passageiro = new Passageiro
                {
                    Nome = "Passageiro 01",
                    Telefone = "+55 (18) 99999-9999",
                    Cpf = "000.000.000-00",
                    Email = "Email 01"
                };

                context.Passageiros.Add(passageiro);

                passageiro = new Passageiro
                {
                    Nome = "Passageiro 02",
                    Telefone = "+55 (18) 88888-8888",
                    Cpf = "111.111.111-11",
                    Email = "Email 02"
                };

                context.Passageiros.Add(passageiro);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListPassageiros()
        {
            using (var context = new MyDbContext())
            {
                foreach (var passageiro in context.Passageiros)
                {
                    Console.WriteLine(JsonSerializer.Serialize(passageiro));
                }
            }
        }


        [TestMethod]
        public void TestInsertOnibus()
        {


            using (var context = new MyDbContext())
            {

                var onibus = new Onibus
                {
                    Placa = "BRA2E24",
                    Modelo = "Volksbus 2028",
                    Wifi = true,
                    Assentos = new List<Assento>()
                };

                int totalAssentos = 10;
                int prioridadeAssentos = (int)Math.Floor(totalAssentos * .1);

                for (int i = 0; i < totalAssentos; i++)
                {
                    bool _prioridade;
                    if (i >= totalAssentos - prioridadeAssentos)
                    {
                        _prioridade = true;
                    }
                    else
                    {
                        _prioridade = false;
                    }
                    var assento = new Assento
                    {
                        NumeroAssento = i + 1,
                        Prioritario = _prioridade,
                        Onibus = onibus
                    };

                    onibus.Assentos.Add(assento);
                }

                context.Onibus.Add(onibus);

                onibus = new Onibus
                {
                    Placa = "BRA2E24",
                    Modelo = "Volksbus 2028",
                    Wifi = true,
                    Assentos = new List<Assento>()
                };

                totalAssentos = 20;
                prioridadeAssentos = (int)Math.Floor(totalAssentos*.1);

                for (int i = 0; i < totalAssentos; i++)
                {
                    bool _prioridade;
                    if (i >= totalAssentos - prioridadeAssentos)
                    {
                        _prioridade = true;
                    }
                    else
                    {
                        _prioridade = false;
                    }
                    var assento = new Assento
                    {
                        NumeroAssento = i + 1,
                        Prioritario = _prioridade,
                        Onibus = onibus
                    };

                    onibus.Assentos.Add(assento);
                }

                context.Onibus.Add(onibus);

                context.SaveChanges();
            }

        }

        [TestMethod]
        public void TestListOnibus()
        {
            using (var context = new MyDbContext())
            {
                foreach (var onibus in context.Onibus)
                {
                    Console.WriteLine(JsonSerializer.Serialize(onibus));
                }
            }
        }

        [TestMethod]
        public void TestListAssentos()
        {
            using (var context = new MyDbContext())
            {
                foreach (var assentos in context.Assentos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(assentos));
                }
            }
        }

        [TestMethod]
        public void TestInsertViagem()
        {
            using (var context = new MyDbContext())
            {

                var onibus = context.Onibus.FirstOrDefault(c => c.Id == 1);
                var origem = context.Cidades.FirstOrDefault(c => c.Id == 1);
                var destino = context.Cidades.FirstOrDefault(c => c.Id == 2);

                var viagem = new Viagem
                {
                    DataSaida = DateTime.Parse("2024-12-4 13:30:00"),
                    DataChegada = DateTime.Parse("2024-12-4 16:40:00"),
                    Onibus = onibus,
                    Destino = destino,
                    Origem = origem
                };

                context.Viagens.Add(viagem);

                onibus = context.Onibus.FirstOrDefault(c => c.Id == 2);
                origem = context.Cidades.FirstOrDefault(c => c.Id == 2);
                destino = context.Cidades.FirstOrDefault(c => c.Id == 1);

                viagem = new Viagem
                {
                    DataSaida = DateTime.Parse("2024-12-5 08:30:00"),
                    DataChegada = DateTime.Parse("2024-12-5 14:40:00"),
                    Onibus = onibus,
                    Destino = destino,
                    Origem = origem
                };

                context.Viagens.Add(viagem);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListViagens()
        {
            using (var context = new MyDbContext())
            {
                foreach (var viagem in context.Viagens)
                {
                    Console.WriteLine(JsonSerializer.Serialize(viagem));
                }
            }
        }

        [TestMethod]
        public void TestInsertReservas()
        {

            using (var context = new MyDbContext())
            {

                var passageiro = context.Passageiros.FirstOrDefault(c => c.Id == 1);
                var viagem = context.Viagens.FirstOrDefault(c => c.Id == 1);
                var onibus = context.Onibus.Include(o => o.Assentos).FirstOrDefault(c => c.Id == 1);
                var assento = onibus?.Assentos?.FirstOrDefault(c => c.NumeroAssento == 1);

                var reserva = new Reserva
                {
                    Viagem = viagem,
                    Passageiro = passageiro,
                    Assento = assento
                };

                context.Reservas.Add(reserva);

                passageiro = context.Passageiros.FirstOrDefault(c => c.Id == 2);
                viagem = context.Viagens.FirstOrDefault(c => c.Id == 2);
                onibus = context.Onibus.Include(o => o.Assentos).FirstOrDefault(c => c.Id == 2);
                assento = onibus?.Assentos?.FirstOrDefault(c => c.NumeroAssento == 5);

                reserva = new Reserva
                {
                    Viagem = viagem,
                    Passageiro = passageiro,
                    Assento = assento
                };

                context.Reservas.Add(reserva);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListReservas()
        {
            using (var context = new MyDbContext())
            {
                foreach (var reserva in context.Reservas)
                {
                    Console.WriteLine(JsonSerializer.Serialize(reserva));
                }
            }
        }
    }
}
