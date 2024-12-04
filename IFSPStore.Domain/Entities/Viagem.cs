using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Viagem : BaseEntity<int>
    {
        public Viagem()
        {

        }

        public Viagem(int id, DateTime dataSaida, DateTime dataChegada, Onibus onibus, Cidade destino, Cidade origem)
        {
            Id = id;
            DataSaida = dataSaida;
            DataChegada = dataChegada;
            Onibus = onibus;
            Destino = destino;
            Origem = origem;
        }

        public DateTime DataSaida { get; set; }
        public DateTime DataChegada { get; set; }
        public Onibus? Onibus { get; set; }
        public Cidade? Destino { get; set; }
        public Cidade? Origem { get; set; }

    }
}
