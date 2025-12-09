using System;
using System.Collections.Generic;

namespace BancoDigitalUno.Domain.Entities
{
    public class Pessoa
    {
        #region "Attributes"

        public int PessoaId { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string CpfCnpj { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime DataRegistro { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        // Navigation properties.
        public virtual ICollection<Endereco> Enderecos { get; set; }

        #endregion


        #region "Methods"



        #endregion
    }
}
