using BancoDigitalUno.Domain.Entities;
using BancoDigitalUno.Domain.Interfaces.Repository;
using BancoDigitalUno.Infra.Data.Persistence;

namespace BancoDigitalUno.Infra.Data.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {        
        #region "Constructor"

        public ClienteRepository(BduDbContext dbContext)
            : base(dbContext)
        {
            
        }

        #endregion
    }
}
