using BancoDigitalUno.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BancoDigitalUno.Infra.Data.EntityConfiguration
{
    public class ContaConfig : EntityTypeConfiguration<Conta>
    {
        public ContaConfig()
        {
            HasKey(c => c.ContaId);

            Property(c => c.ContaId)
                .IsRequired();

            Property(c => c.Agencia)
                .IsRequired()
                .HasMaxLength(10);

            Property(c => c.NumeroConta)
                .IsRequired()
                .HasMaxLength(10);

            Property(c => c.DigitoVerificador)
                .IsRequired()
                .HasMaxLength(2);

            Property(c => c.TipoConta)
                .IsRequired();

            Property(c => c.Saldo)
                .IsRequired();

            Property(c => c.IsAtiva)
                .IsRequired();

            Property(c => c.DataRegistro)
                .IsRequired();

            Property(c => c.DataAtualizacao)
                .IsOptional();

            // Navigation properties.
            Property(c => c.ClienteId)
                .IsRequired();
        }
    }
}
