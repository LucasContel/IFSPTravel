
using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class ReservaMap : IEntityTypeConfiguration<Reserva>
    {
        public void Configure(EntityTypeBuilder<Reserva> builder)
        {
            builder.ToTable("Reserva");

            builder.HasKey(prop => prop.Id);

            builder.HasOne(prop => prop.Viagem)
                .WithMany()
                .HasConstraintName("FK_Viagem");

            builder.HasOne(prop => prop.Passageiro)
                .WithMany()
                .HasConstraintName("FK_Passageiro");

            builder.HasOne(prop => prop.Assento)
                .WithMany()
                .HasConstraintName("FK_Assento");
        }
    }
}
