using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Passageiro : BaseEntity<int>
    {
        public Passageiro()
        {

        }

        public Passageiro(int id, string nome, string telefone, string cpf, string email)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Cpf = cpf;
            Email = email;
        }

        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }

    }
}
