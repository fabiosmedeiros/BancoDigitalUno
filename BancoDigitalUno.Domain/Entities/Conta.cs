using System;

namespace BancoDigitalUno.Domain.Entities
{
    public class Conta
    {
        #region "Attributes"

        public int ContaId { get; set; }

        public string Agencia { get; set; }

        public string NumeroConta { get; set; }

        public string DigitoVerificador { get; set; }

        public TipoConta TipoConta { get; set; }

        public Decimal Saldo { get; set; }

        public bool IsAtiva { get; set; }

        public DateTime DataRegistro { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        // Navigation properties.
        public virtual Cliente Cliente { get; set; }

        public int ClienteId { get; set; }

        #endregion


        #region "Methods"



        #endregion
    }
}
