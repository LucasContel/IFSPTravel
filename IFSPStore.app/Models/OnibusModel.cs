
namespace IFSPStore.app.Models
{
    public class OnibusModel
    {
        public OnibusModel()
        {
            Assentos = new List<AssentoModel>();
        }
        public int Id { get; set; }
        public string? Placa { get; set; }
        public string? Modelo { get; set; }
        public bool Wifi { get; set; }
        public int NumeroAssentos { get; set; }

        public string? ModeloPlaca { get; set; }
        public List<AssentoModel> Assentos { get; set; }
    }

    public class AssentoModel
    {
        public int Id { get; set; }
        public int NumeroAssento { get; set; }

    }
}
