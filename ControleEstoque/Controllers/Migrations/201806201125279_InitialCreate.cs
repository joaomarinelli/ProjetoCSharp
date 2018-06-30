namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Armazems",
                c => new
                    {
                        ArmazemId = c.Int(nullable: false, identity: true),
                        Local = c.String(),
                        ArmazemDesc = c.String(),
                    })
                .PrimaryKey(t => t.ArmazemId);
            
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        FuncionarioId = c.Int(nullable: false, identity: true),
                        NomeFuncionario = c.String(),
                        Cargo = c.String(),
                    })
                .PrimaryKey(t => t.FuncionarioId);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        MaterialId = c.Int(nullable: false, identity: true),
                        MaterialNome = c.String(),
                        MaterialDesc = c.String(),
                    })
                .PrimaryKey(t => t.MaterialId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Materials");
            DropTable("dbo.Funcionarios");
            DropTable("dbo.Armazems");
        }
    }
}
