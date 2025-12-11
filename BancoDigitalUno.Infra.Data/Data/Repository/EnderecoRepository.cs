using BancoDigitalUno.Domain.Entities;
using BancoDigitalUno.Domain.Interfaces.Repository;
using BancoDigitalUno.Infra.Data.Persistence;

namespace BancoDigitalUno.Infra.Data.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        #region "Constructor"

        public EnderecoRepository(BduDbContext dbContext)
            : base(dbContext)
        {
            
        }

        #endregion
    }
}
