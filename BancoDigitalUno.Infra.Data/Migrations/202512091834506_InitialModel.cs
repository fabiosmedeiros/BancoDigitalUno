namespace BancoDigitalUno.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        TipoCliente = c.Int(nullable: false),
                        RendaMedia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsAtivo = c.Boolean(nullable: false),
                        DataRegistro = c.DateTime(nullable: false),
                        DataAtualizacao = c.DateTime(),
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.Conta",
                c => new
                    {
                        ContaId = c.Int(nullable: false, identity: true),
                        Agencia = c.String(nullable: false, maxLength: 10),
                        NumeroConta = c.String(nullable: false, maxLength: 10),
                        DigitoVerificador = c.String(nullable: false, maxLength: 2),
                        TipoConta = c.Int(nullable: false),
                        Saldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsAtiva = c.Boolean(nullable: false),
                        DataRegistro = c.DateTime(nullable: false),
                        DataAtualizacao = c.DateTime(),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContaId)
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        PessoaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Email = c.String(maxLength: 80),
                        CpfCnpj = c.String(nullable: false, maxLength: 11),
                        DataNascimento = c.DateTime(nullable: false),
                        DataRegistro = c.DateTime(nullable: false),
                        DataAtualizacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.PessoaId);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        EnderecoId = c.Int(nullable: false, identity: true),
                        Logradouro = c.String(nullable: false, maxLength: 50),
                        Numero = c.String(nullable: false, maxLength: 6),
                        Complemento = c.String(maxLength: 50),
                        Cep = c.String(nullable: false, maxLength: 8),
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnderecoId)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cliente", "PessoaId", "dbo.Pessoa");
            DropForeignKey("dbo.Endereco", "PessoaId", "dbo.Pessoa");
            DropForeignKey("dbo.Conta", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Endereco", new[] { "PessoaId" });
            DropIndex("dbo.Conta", new[] { "ClienteId" });
            DropIndex("dbo.Cliente", new[] { "PessoaId" });
            DropTable("dbo.Endereco");
            DropTable("dbo.Pessoa");
            DropTable("dbo.Conta");
            DropTable("dbo.Cliente");
        }
    }
}
