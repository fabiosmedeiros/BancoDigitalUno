using BancoDigitalUno.Domain.Entities;
using BancoDigitalUno.Domain.Interfaces.Repository;
using BancoDigitalUno.Infra.Data.Persistence;

namespace BancoDigitalUno.Infra.Data.Data.Repository
{
    public class ContaRepository : Repository<Conta>, IContaRepository
    {
        #region "Constructor"

        public ContaRepository(BduDbContext dbContext)
            : base(dbContext)
        {
            
        }

        #endregion
    }
}
