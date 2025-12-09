using BancoDigitalUno.Domain.Entities;
using BancoDigitalUno.Infra.Data.EntityConfiguration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BancoDigitalUno.Infra.Data.Persistence
{
    public class BduDbContext : DbContext
    {
        #region "DbSets"

        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Conta> Contas { get; set; }

        #endregion


        #region "Constructor"

        public BduDbContext()
            : base("BduDb")
        {

        }

        #endregion


        #region "Methods"

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new PessoaConfig());
            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new ContaConfig());
        }

        #endregion
    }
}
