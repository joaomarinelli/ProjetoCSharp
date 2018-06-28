namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_CodMaterial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Materiais", "CodMaterial", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Materiais", "CodMaterial");
        }
    }
}
