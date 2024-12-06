
using AutoMapper;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using IFSPStore.Service.Services;
using IFSPStore.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Text.Json;

namespace IFSPStore.Test
{
    [TestClass]
    public class TesteService
    {

        private ServiceCollection? services;

        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<SqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "IFSPTravel";
                var username = "root";
                var password = "ifsp";
                var strCon = $"Server={server};Port={port};Database={database};" +
                    $"Uid={username};Pwd={password}";

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(100);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Passageiro>, BaseRepository<Passageiro>>();
            services.AddScoped<IBaseService<Passageiro>, BaseService<Passageiro>>();

            services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();

            services.AddScoped<IBaseRepository<Onibus>, BaseRepository<Onibus>>();
            services.AddScoped<IBaseService<Onibus>, BaseService<Onibus>>();

            services.AddScoped<IBaseRepository<Assento>, BaseRepository<Assento>>();
            services.AddScoped<IBaseService<Assento>, BaseService<Assento>>();

            services.AddScoped<IBaseRepository<Viagem>, BaseRepository<Viagem>>();
            services.AddScoped<IBaseService<Viagem>, BaseService<Viagem>>();

            services.AddScoped<IBaseRepository<Reserva>, BaseRepository<Reserva>>();
            services.AddScoped<IBaseService<Reserva>, BaseService<Reserva>>();

            services.AddSingleton(new MapperConfiguration(config =>
            {

                //config.CreateMap<Usuario, Usuario>();
                //config.CreateMap<Cidade, Cidade>();
                //config.CreateMap<Cliente, Cliente>();
                //config.CreateMap<Grupo, Grupo>();
                //config.CreateMap<Produto, Produto>();
                //config.CreateMap<VendaItem, VendaItem>();
                //config.CreateMap<Venda, Venda>();

            }).CreateMapper());

            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestPassageiro()
        {
            var sp = ConfigureServices();

            var passageiroService = sp.GetService<IBaseService<Passageiro>>();
            var passageiro = new Passageiro
            {
                Nome = "Passageiro 01",
                Telefone = "+55 18 99999-9999",
                Cpf = "000.000.000-00",
                Email = "passageiro01@gmal.com"
            };

            var result = passageiroService?.Add<Passageiro, Passageiro, PassageiroValidator>(passageiro);

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectPassageiro()
        {
            var sp = ConfigureServices();
            var passageiroService = sp.GetService<IBaseService<Passageiro>>();

            var result = passageiroService?.Get<Passageiro>();

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestCidade()
        {
            var sp = ConfigureServices();

            var CidadeService = sp.GetService<IBaseService<Cidade>>();
            var cidade = new Cidade
            {
                Nome = "Birigui",
                Estado = "SP"
            };

            var result = CidadeService?.Add<Cidade, Cidade, CidadeValidator>(cidade);

            cidade = new Cidade
            {
                Nome = "Araçatuba",
                Estado = "SP"
            };

            result = CidadeService?.Add<Cidade, Cidade, CidadeValidator>(cidade);

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectCidade()
        {
            var sp = ConfigureServices();

            var CidadeService = sp.GetService<IBaseService<Cidade>>();

            var result = CidadeService?.Get<Cidade>();

            Console.Write(JsonSerializer.Serialize(result));
        }


        [TestMethod]
        public void TestOnibus()
        {
            var sp = ConfigureServices();

            var onibusService = sp.GetService<IBaseService<Onibus>>();

            var assentoService = sp.GetService<IBaseService<Assento>>();

            var onibus = new Onibus
            {
                Placa = "BRA2E24",
                Modelo = "Volksbus",
                Wifi = true,
                Assentos = new List<Assento>()
            };

            var assento = new Assento
            {
                NumeroAssento = 4,
                Prioritario = false,
                Onibus = onibus
            };

            onibus.Assentos.Add(assento);

            sp.GetService<SqlContext>().Entry(onibus).State = EntityState.Added;

            var resultOnibus = onibusService?.Add<Onibus, Onibus, OnibusValidator>(onibus);

            var resultAssento = assentoService?.Add<Assento, Assento, AssentoValidator>(assento);

            Console.Write(JsonSerializer.Serialize(resultOnibus));
            Console.Write(JsonSerializer.Serialize(resultAssento));

        }

        [TestMethod]
        public void TestSelectAssento()
        {
            var sp = ConfigureServices();

            var assentoItemService = sp.GetService<IBaseService<Assento>>();

            var result = assentoItemService?.Get<Assento>();

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectOnibus()
        {
            var sp = ConfigureServices();
            var onibusService = sp.GetService<IBaseService<Onibus>>();

            var result = onibusService?.Get<Onibus>();

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestViagem()
        {
            var sp = ConfigureServices();

            var onibusService = sp.GetService<IBaseService<Onibus>>();

            var cidadeService = sp.GetService<IBaseService<Cidade>>();

            var viagemService = sp.GetService<IBaseService<Viagem>>();

            var onibus = onibusService?.Get<Onibus>().FirstOrDefault(c => c.Id == 1);
            var origem = cidadeService?.Get<Cidade>().FirstOrDefault(c => c.Id == 1);
            var destino = cidadeService?.Get<Cidade>().FirstOrDefault(c => c.Id == 2);

            var viagem = new Viagem
            {
                DataSaida = DateTime.Parse("2024-12-4 13:30:00"),
                DataChegada = DateTime.Parse("2024-12-4 16:40:00"),
                Onibus = onibus,
                Destino = destino,
                Origem = origem
            };

            var result = viagemService?.Add<Viagem, Viagem, ViagemValidator>(viagem);

            Console.Write(JsonSerializer.Serialize(result));

        }

        [TestMethod]
        public void TestSelectViagem()
        {
            var sp = ConfigureServices();
            var viagemService = sp.GetService<IBaseService<Viagem>>();

            var result = viagemService?.Get<Viagem>();

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestReserva()
        {
            var sp = ConfigureServices();

            var reservaService = sp.GetService<IBaseService<Reserva>>();

            var viagemService = sp.GetService<IBaseService<Viagem>>();

            var passageiroService = sp.GetService<IBaseService<Passageiro>>();

            var onibusService = sp.GetService<IBaseService<Onibus>>();

            var assentoService = sp.GetService<IBaseService<Assento>>();

            var viagem = viagemService?.Get<Viagem>().FirstOrDefault(c => c.Id == 1);

            var passageiro = passageiroService?.Get<Passageiro>().FirstOrDefault(c => c.Id == 1);

            var onibus = onibusService?.Get<Onibus>().FirstOrDefault(c => c.Id == 3);

            var assento = assentoService?.Get<Assento>().FirstOrDefault(a => a.Onibus.Id == onibus.Id && a.NumeroAssento == 4);

            var reserva = new Reserva()
            {
                Viagem = viagem,
                Passageiro = passageiro,
                Assento = assento
            };

            var result = reservaService?.Add<Reserva, Reserva, ReservaValidator>(reserva);

            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectReserva()
        {
            var sp = ConfigureServices();

            var reservaService = sp.GetService<IBaseService<Reserva>>();

            var result = reservaService?.Get<Reserva>();

            Console.Write(JsonSerializer.Serialize(result));
        }
    }
}
