namespace BancoDigitalUno.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Campos_Data_Endereco : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Endereco", "DataRegistro", c => c.DateTime(nullable: false));
            AddColumn("dbo.Endereco", "DataAtualizacao", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Endereco", "DataAtualizacao");
            DropColumn("dbo.Endereco", "DataRegistro");
        }
    }
}
