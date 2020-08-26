namespace BethanyPieShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingOnePropertityinRegister : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Registers", "EmialId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Registers", "EmialId");
        }
    }
}
