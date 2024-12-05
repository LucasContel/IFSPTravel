
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
            /*
            Services.AddTransient<CadastroCidade, CadastroCidade>();
            Services.AddTransient<CadastroCliente, CadastroCliente>();
            Services.AddTransient<CadastroGrupo, CadastroGrupo>();
            Services.AddTransient<CadastroProduto, CadastroProduto>();
            Services.AddTransient<CadastroUsuario, CadastroUsuario>();
            Services.AddTransient<CadastroVenda, CadastroVenda>();
            Services.AddTransient<Login, Login>();
            */

            #endregion

            #region Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                
                config.CreateMap<Cidade, CidadeModel>()
                .ForMember(c => c.NomeEstado, c => c.MapFrom(x => $"{x.Nome}/{x.Estado}"));

                config.CreateMap<Onibus, OnibusModel>()
                .ForMember(c => c.NumeroAssentos, c => c.MapFrom(x => x.Assentos!.Count));

                config.CreateMap<Assento, AssentoModel>();
                
                config.CreateMap<Passageiro, PassageiroModel>();

                config.CreateMap<Viagem, ViagemModel>()
                .ForMember(c => c.ModeloOnibus, c => c.MapFrom(x => x.Onibus!.Modelo))
                .ForMember(c => c.IdOnibus, c => c.MapFrom(x => x.Onibus!.Id))
                .ForMember(c => c.CidadeOrigem, c => c.MapFrom(x => $"{x.Origem!.Nome}/{x.Origem!.Estado}"))
                .ForMember(c => c.IdOrigem, c => c.MapFrom(x => x.Origem!.Id))
                .ForMember(c => c.CidadeDestino, c => c.MapFrom(x => $"{x.Destino!.Nome}/{x.Destino!.Estado}"))
                .ForMember(c => c.IdDestino, c => c.MapFrom(x => x.Destino!.Id));


                config.CreateMap<Reserva, ReservaModel>()
                .ForMember(c => c.ViagemDestino, c => c.MapFrom(x => x.Viagem!.Destino))
                .ForMember(c => c.ViagemOrigem, c => c.MapFrom(x => x.Viagem!.Origem))
                .ForMember(c => c.IdViagem, c => c.MapFrom(x => x.Viagem!.Id))
                .ForMember(c => c.NomePassageiro, c => c.MapFrom(x => x.Passageiro!.Nome))
                .ForMember(c => c.IdPassageiro, c => c.MapFrom(x => x.Passageiro!.Id))
                .ForMember(c => c.NumeroAssento, c => c.MapFrom(x => x.Assento!.NumeroAssento))
                .ForMember(c => c.IdAssento, c => c.MapFrom(x => x.Assento!.Id));                

            }).CreateMapper());
            #endregion

            ServicesProvider = Services.BuildServiceProvider();
        }

    }
}
