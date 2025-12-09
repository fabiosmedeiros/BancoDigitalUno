using BancoDigitalUno.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BancoDigitalUno.Infra.Data.EntityConfiguration
{
    public class PessoaConfig : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfig()
        {
            HasKey(c => c.PessoaId);

            Property(c => c.PessoaId)
                .IsRequired();

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.Email)
                .IsOptional()
                .HasMaxLength(80);

            Property(c => c.CpfCnpj)
                .IsRequired()
                .HasMaxLength(11);

            Property(c => c.DataNascimento)
                .IsRequired();

            Property(c => c.DataRegistro)
                .IsRequired();

            Property(c => c.DataAtualizacao)
                .IsOptional();
        }
    }
}
