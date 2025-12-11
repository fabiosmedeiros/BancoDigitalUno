using BancoDigitalUno.Domain.Entities;
using BancoDigitalUno.Domain.Interfaces.Repository;
using BancoDigitalUno.Infra.Data.Persistence;

namespace BancoDigitalUno.Infra.Data.Data.Repository
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        #region "Constructor"

        public PessoaRepository(BduDbContext dbContext)
            : base(dbContext)
        {
            
        }

        #endregion
    }
}
