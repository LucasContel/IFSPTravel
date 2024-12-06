using IFSPStore.Domain.Base;
using System.Text.Json.Serialization;

namespace IFSPStore.Domain.Entities
{
    public class Onibus : BaseEntity<int>
    {
        public Onibus()
        {
            Assentos = new List<Assento>();
        }

        public Onibus(int id, string placa, string modelo, bool wifi, List<Assento> assentos)
        {
            Id = id;
            Placa = placa;
            Modelo = modelo;
            Wifi = wifi;
            Assentos = assentos;
        }

        public string? Placa { get; set; }
        public string? Modelo { get; set; }
        public bool Wifi { get; set; }
        public List<Assento>? Assentos { get; set; }
    }

    public class Assento : BaseEntity<int>
    {
        public Assento()
        {
            
        }

        public Assento(int id, int numeroAssento, Onibus onibus, bool prioritario)
        {
            Id = id;
            NumeroAssento = numeroAssento;
            Prioritario = prioritario;
            Onibus = onibus;
            Prioritario = prioritario;
        }

        public bool Prioritario { get; set; }
        public int NumeroAssento { get; set; }
        [JsonIgnore]
        public Onibus? Onibus { get; set; }


    }
}
