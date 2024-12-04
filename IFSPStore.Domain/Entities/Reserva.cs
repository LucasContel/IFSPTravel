using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Reserva : BaseEntity<int>
    {
        public Reserva()
        {

        }

        public Reserva(int id, Viagem viagem, Passageiro passageiro, Assento assento)
        {
            Id = id;
            Viagem = viagem;
            Passageiro = passageiro;
            Assento = assento;
        }

        public Viagem? Viagem { get; set; }
        public Passageiro? Passageiro { get; set; }
        public Assento? Assento { get; set; }
    }
}
