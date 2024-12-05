namespace IFSPStore.app.Models
{
    public class ReservaModel
    {
        public int Id { get; set; }
        public int IdViagem { get; set; }
        public string? ViagemOrigem { get; set; }
        public string? ViagemDestino { get; set; }
        public int IdPassageiro { get; set; }
        public string? NomePassageiro { get; set; }
        public int IdAssento { get; set; }
        public int NumeroAssento{ get; set; }
    }
}
