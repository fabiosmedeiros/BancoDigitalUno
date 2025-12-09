using BancoDigitalUno.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BancoDigitalUno.Infra.Data.EntityConfiguration
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(c => c.EnderecoId);

            Property(c => c.EnderecoId)
                .IsRequired();

            Property(c => c.Logradouro)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Numero)
                .IsRequired()
                .HasMaxLength(6);

            Property(c => c.Complemento)
                .IsOptional()
                .HasMaxLength(50);

            Property(c => c.Cep)
                .IsRequired()
                .HasMaxLength(8);

            // Navigation properties.
            Property(c => c.PessoaId)
                .IsRequired();
        }
    }
}
