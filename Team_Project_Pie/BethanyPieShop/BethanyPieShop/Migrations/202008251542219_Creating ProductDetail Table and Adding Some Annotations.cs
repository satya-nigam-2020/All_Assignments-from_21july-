namespace BethanyPieShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingProductDetailTableandAddingSomeAnnotations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductDetails",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            AlterColumn("dbo.Registers", "EmialId", c => c.String(nullable: false));
            AlterColumn("dbo.Registers", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Registers", "Password", c => c.String());
            AlterColumn("dbo.Registers", "EmialId", c => c.String());
            DropTable("dbo.ProductDetails");
        }
    }
}
