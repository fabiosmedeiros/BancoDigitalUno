using BancoDigitalUno.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BancoDigitalUno.Infra.Data.EntityConfiguration
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            HasKey(c => c.ClienteId);

            Property(c => c.ClienteId)
                .IsRequired();

            Property(c => c.TipoCliente)
                .IsRequired();

            Property(c => c.RendaMedia)
                .IsRequired();

            Property(c => c.IsAtivo)
                .IsRequired();

            Property(c => c.DataRegistro)
                .IsRequired();

            Property(c => c.DataAtualizacao)
                .IsOptional();

            // Navigation properties.
            Property(c => c.PessoaId)
                .IsRequired();
        }
    }
}
