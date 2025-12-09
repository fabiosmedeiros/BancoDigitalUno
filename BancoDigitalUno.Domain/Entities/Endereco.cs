namespace BancoDigitalUno.Domain.Entities
{
    public class Endereco
    {
        #region "Attributes"

        public int EnderecoId { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Cep { get; set; }

        // Navigation properties.
        public virtual Pessoa Pessoa { get; set; }

        public int PessoaId { get; set; }

        #endregion


        #region "Methods"



        #endregion
    }
}
