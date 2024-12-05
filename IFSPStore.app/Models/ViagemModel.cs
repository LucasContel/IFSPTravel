
namespace IFSPStore.app.Models
{
    public class ViagemModel
    {
        public int Id { get; set; }
        public DateTime? DataSaida { get; set; }
        public DateTime? DataChegada { get; set; }
        public int IdOnibus { get; set; }
        public string? ModeloOnibus { get; set; }
        public int IdOrigem { get; set; }
        public string? CidadeOrigem { get; set; }
        public int IdDestino { get; set; }
        public string? CidadeDestino { get; set; }

    }
}
