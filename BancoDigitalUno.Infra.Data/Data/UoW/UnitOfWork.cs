using BancoDigitalUno.Domain.Interfaces.Repository;
using BancoDigitalUno.Domain.Interfaces.UoW;
using BancoDigitalUno.Infra.Data.Data.Repository;
using BancoDigitalUno.Infra.Data.Persistence;

namespace BancoDigitalUno.Infra.Data.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        #region "Attributes"

        private readonly BduDbContext _dbContext = new BduDbContext();

        private bool isDisposed = false;

        #endregion


        #region "Repositories"

        private PessoaRepository pessoaRepository;

        private ClienteRepository clienteRepository;

        private ContaRepository contaRepository;

        private EnderecoRepository enderecoRepository;

        #endregion


        #region "Properties"

        public IPessoaRepository PessoaRepository
        {
            get
            {
                if (this.pessoaRepository == null)
                {
                    this.pessoaRepository = new PessoaRepository(_dbContext);
                }

                return this.pessoaRepository;
            }
        }

        public IClienteRepository ClienteRepository
        {
            get
            {
                if (this.clienteRepository == null)
                {
                    this.clienteRepository = new ClienteRepository(_dbContext);
                }

                return this.clienteRepository;
            }
        }

        public IContaRepository ContaRepository
        {
            get
            {
                if (this.contaRepository == null)
                {
                    this.contaRepository = new ContaRepository(_dbContext);
                }

                return this.contaRepository;
            }
        }

        public IEnderecoRepository EnderecoRepository
        {
            get
            {
                if (this.enderecoRepository == null)
                {
                    this.enderecoRepository = new EnderecoRepository(_dbContext);
                }

                return this.enderecoRepository;
            }
        }

        #endregion


        #region "Save"

        public void Complete()
        {
            _dbContext.SaveChanges();
        }

        #endregion


        #region Dispose

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (!this.isDisposed)
            {
                if (isDisposing)
                {
                    _dbContext.Dispose();
                }
            }

            this.isDisposed = true;
        }

        #endregion
    }
}
