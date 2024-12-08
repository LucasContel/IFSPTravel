
using AutoMapper;
using IFSPStore.app.Base;
using IFSPStore.app.Cadastros;
using IFSPStore.app.Models;
using IFSPStore.app.Outros;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using IFSPStore.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration.Internal;

namespace IFSPStore.app.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static IServiceProvider? ServicesProvider;

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();
            #region Banco_de_dados
            var strCon = File.ReadAllText("Config/ConfigBanco.txt");

            Services.AddDbContext<SqlContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging();
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(100);
                    opt.EnableRetryOnFailure();
                });
            });

            #endregion

            #region Repositórios
            Services.AddScoped<IBaseRepository<Passageiro>, BaseRepository<Passageiro>>();
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            Services.AddScoped<IBaseRepository<Onibus>, BaseRepository<Onibus>>();
            Services.AddScoped<IBaseRepository<Assento>, BaseRepository<Assento>>();
            Services.AddScoped<IBaseRepository<Viagem>, BaseRepository<Viagem>>();
            Services.AddScoped<IBaseRepository<Reserva>, BaseRepository<Reserva>>();
            #endregion

            #region Serviços
            Services.AddScoped<IBaseService<Passageiro>, BaseService<Passageiro>>();
            Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            Services.AddScoped<IBaseService<Onibus>, BaseService<Onibus>>();
            Services.AddScoped<IBaseService<Assento>, BaseService<Assento>>();
            Services.AddScoped<IBaseService<Viagem>, BaseService<Viagem>>();
            Services.AddScoped<IBaseService<Reserva>, BaseService<Reserva>>();
            #endregion

            #region Formulários
            Services.AddTransient<CadastroCidade, CadastroCidade>();
            Services.AddTransient<CadastroPassageiro, CadastroPassageiro>();
            Services.AddTransient<CadastroOnibus, CadastroOnibus>();
            Services.AddTransient<CadastroViagem, CadastroViagem>();
            Services.AddTransient<CadastroReserva, CadastroReserva>();
            Services.AddTransient<Rota, Rota>();

            #endregion

            #region Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                
                config.CreateMap<Cidade, CidadeModel>()
                .ForMember(c => c.NomeEstado, c => c.MapFrom(x => $"{x.Nome}/{x.Estado}"));

                config.CreateMap<Onibus, OnibusModel>()
                .ForMember(c => c.NumeroAssentos, c => c.MapFrom(x => x.Assentos!.Count))
                .ForMember(c => c.ModeloPlaca, c => c.MapFrom(x => $"{x.Modelo} - {x.Placa}"));

                config.CreateMap<Assento, AssentoModel>();
                
                config.CreateMap<Passageiro, PassageiroModel>()
                .ForMember(c => c.NomeCpf, c => c.MapFrom(x => $"{x.Nome} / {x.Cpf}"));

                config.CreateMap<Viagem, ViagemModel>()
                .ForMember(c => c.IdOnibus, c => c.MapFrom(x => x.Onibus!.Id))
                .ForMember(c => c.ModeloOnibus, c => c.MapFrom(x => x.Onibus!.Modelo))
                .ForMember(c => c.CidadeOrigem, c => c.MapFrom(x => $"{x.Origem!.Nome}/{x.Origem!.Estado}"))
                .ForMember(c => c.IdOrigem, c => c.MapFrom(x => x.Origem!.Id))
                .ForMember(c => c.CidadeDestino, c => c.MapFrom(x => $"{x.Destino!.Nome}/{x.Destino!.Estado}"))
                .ForMember(c => c.IdDestino, c => c.MapFrom(x => x.Destino!.Id))
                .ForMember(c => c.Informacoes, c => c.MapFrom(x => $"{x.Origem!.Nome}/{x.Origem!.Estado} - {x.Destino!.Nome}/{x.Destino!.Estado} - {x.Onibus!.Modelo}/{x.Onibus!.Placa} - {x.DataSaida:dd/MM/yy HH:mm} - {x.DataChegada:dd/MM/yy HH:mm}"));


                config.CreateMap<Reserva, ReservaModel>()
                .ForMember(c => c.ViagemDestino, c => c.MapFrom(x => $"{x.Viagem!.Destino!.Nome}/{x.Viagem!.Destino.Estado}"))
                .ForMember(c => c.ViagemOrigem, c => c.MapFrom(x => $"{x.Viagem!.Origem!.Nome}/{x.Viagem!.Origem.Estado}"))
                .ForMember(c => c.IdViagem, c => c.MapFrom(x => x.Viagem!.Id))
                .ForMember(c => c.NomeCpf, c => c.MapFrom(x => $"{x.Passageiro!.Nome} / {x.Passageiro.Cpf}"))
                .ForMember(c => c.IdPassageiro, c => c.MapFrom(x => x.Passageiro!.Id))
                .ForMember(c => c.IdAssento, c => c.MapFrom(x => x.Assento!.Id))
                .ForMember(c => c.NumeroAssento, c => c.MapFrom(x => x.Assento!.NumeroAssento))
                .ForMember(c => c.HoraSaida, c => c.MapFrom(x => $"{x.Viagem!.DataSaida:dd/MM/yy HH:mm}"))
                .ForMember(c => c.HoraChegada, c => c.MapFrom(x => $"{x.Viagem!.DataChegada:dd/MM/yy HH:mm}"))
                .ForMember(c => c.Onibus, c => c.MapFrom(x => $"{x.Viagem!.Onibus!.Modelo}/{x.Viagem!.Onibus!.Placa}"));


            }).CreateMapper());
            #endregion

            ServicesProvider = Services.BuildServiceProvider();
        }

    }
}
