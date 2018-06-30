namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Table_Material_Armazem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Materials", "Local_Armazem_ArmazemId", c => c.Int());
            CreateIndex("dbo.Materials", "Local_Armazem_ArmazemId");
            AddForeignKey("dbo.Materials", "Local_Armazem_ArmazemId", "dbo.Armazems", "ArmazemId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Materials", "Local_Armazem_ArmazemId", "dbo.Armazems");
            DropIndex("dbo.Materials", new[] { "Local_Armazem_ArmazemId" });
            DropColumn("dbo.Materials", "Local_Armazem_ArmazemId");
        }
    }
}
