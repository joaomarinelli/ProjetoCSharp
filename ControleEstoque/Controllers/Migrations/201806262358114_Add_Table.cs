namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Table : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Materials", newName: "Materiais");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Materiais", newName: "Materials");
        }
    }
}
