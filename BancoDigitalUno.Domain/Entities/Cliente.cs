using System;
using System.Collections.Generic;

namespace BancoDigitalUno.Domain.Entities
{
    public class Cliente
    {
        #region "Attributes"

        public int ClienteId { get; set; }

        public TipoCliente TipoCliente { get; set; }

        public Decimal RendaMedia { get; set; }

        public bool IsAtivo { get; set; }

        public DateTime DataRegistro { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        // Navigation properties.
        public virtual Pessoa Pessoa { get; set; }

        public int PessoaId { get; set; }

        public virtual ICollection<Conta> Contas { get; set; }

        #endregion


        #region "Methods"



        #endregion
    }
}
