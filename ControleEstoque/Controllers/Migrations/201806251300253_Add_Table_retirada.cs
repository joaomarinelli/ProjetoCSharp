namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Table_retirada : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Retiradas",
                c => new
                    {
                        RetiradaId = c.Int(nullable: false, identity: true),
                        QuantidadeRetirada = c.Int(nullable: false),
                        DataRetirada = c.DateTime(nullable: false),
                        FuncionarioRetirada_FuncionarioId = c.Int(),
                        MaterialRetirado_MaterialId = c.Int(),
                    })
                .PrimaryKey(t => t.RetiradaId)
                .ForeignKey("dbo.Funcionarios", t => t.FuncionarioRetirada_FuncionarioId)
                .ForeignKey("dbo.Materials", t => t.MaterialRetirado_MaterialId)
                .Index(t => t.FuncionarioRetirada_FuncionarioId)
                .Index(t => t.MaterialRetirado_MaterialId);
            
            AddColumn("dbo.Materials", "QuantidadeCadastrada", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Retiradas", "MaterialRetirado_MaterialId", "dbo.Materials");
            DropForeignKey("dbo.Retiradas", "FuncionarioRetirada_FuncionarioId", "dbo.Funcionarios");
            DropIndex("dbo.Retiradas", new[] { "MaterialRetirado_MaterialId" });
            DropIndex("dbo.Retiradas", new[] { "FuncionarioRetirada_FuncionarioId" });
            DropColumn("dbo.Materials", "QuantidadeCadastrada");
            DropTable("dbo.Retiradas");
        }
    }
}
