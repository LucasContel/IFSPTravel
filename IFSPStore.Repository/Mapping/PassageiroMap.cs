
using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class PassageiroMap : IEntityTypeConfiguration<Passageiro>
    {
        public void Configure(EntityTypeBuilder<Passageiro> builder)
        {
            builder.ToTable("Passageiro");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .HasMaxLength(100);

            builder.Property(prop => prop.Telefone)
                .HasMaxLength(30);

            builder.Property(prop => prop.Cpf)
                .HasMaxLength(16);

            builder.Property(prop => prop.Email)
                .HasMaxLength(60);
        }
    }
}
