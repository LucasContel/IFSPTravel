using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class ViagemMap : IEntityTypeConfiguration<Viagem>
    {
        public void Configure(EntityTypeBuilder<Viagem> builder)
        {
            builder.ToTable("Viagem");

            builder.HasKey(prop => prop.Id);


            builder.Property(prop => prop.DataSaida);

            builder.Property(prop => prop.DataChegada);

            builder.HasOne(prop => prop.Onibus)
                .WithMany()
                .HasConstraintName("FK_Onibus");

            builder.HasOne(prop => prop.Destino)
                .WithMany()
                .HasConstraintName("FK_Destino");

            builder.HasOne(prop => prop.Origem)
                .WithMany()
                .HasConstraintName("FK_Origem");
        }
    }
}
