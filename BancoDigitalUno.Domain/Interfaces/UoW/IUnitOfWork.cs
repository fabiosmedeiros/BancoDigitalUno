using BancoDigitalUno.Domain.Interfaces.Repository;
using System;

namespace BancoDigitalUno.Domain.Interfaces.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        #region "Properties"

        IPessoaRepository PessoaRepository { get; }
                
        IClienteRepository ClienteRepository { get; }
                
        IContaRepository ContaRepository { get; }
        
        IEnderecoRepository EnderecoRepository { get; }        

        #endregion


        #region "Save"

        void Complete();

        #endregion
    }
}
