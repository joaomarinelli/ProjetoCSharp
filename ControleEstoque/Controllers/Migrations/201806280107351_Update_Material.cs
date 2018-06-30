namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Material : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Materiais", "QuantidadeCadastrada", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Materiais", "QuantidadeCadastrada", c => c.Int(nullable: false));
        }
    }
}
