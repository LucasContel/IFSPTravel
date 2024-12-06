using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class OnibusMap : IEntityTypeConfiguration<Onibus>
    {
        public void Configure(EntityTypeBuilder<Onibus> builder)
        {
            builder.ToTable("Onibus");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Placa)
                .IsRequired()
                .HasMaxLength(12);

            builder.Property(prop => prop.Modelo)
                .HasMaxLength(50);

            builder.Property(prop => prop.Wifi);

            builder.HasMany(prop => prop.Assentos)
            .WithOne(prop => prop.Onibus)
            .OnDelete(DeleteBehavior.Cascade);

        }
    }

    public class AssentoMap : IEntityTypeConfiguration<Assento>
    {
        public void Configure(EntityTypeBuilder<Assento> builder)
        {
            builder.ToTable("Assento");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.NumeroAssento)
                .IsRequired();

            builder.Property(prop => prop.Prioritario);

            builder.HasOne(prop => prop.Onibus)
                .WithMany(prop => prop.Assentos)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
