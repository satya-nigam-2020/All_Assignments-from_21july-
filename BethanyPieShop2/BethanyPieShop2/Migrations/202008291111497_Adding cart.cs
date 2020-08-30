namespace BethanyPieShop2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addingcart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PieType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        NoOfOrder = c.Int(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        IsDelivered = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Registers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Registers",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FName = c.String(nullable: false, maxLength: 20),
                        LName = c.String(nullable: false, maxLength: 20),
                        PhoneNo = c.String(nullable: false),
                        EmailId = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.ProductDetails",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        Price = c.Double(nullable: false),
                        ImagePath = c.String(),
                        CatagoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.CatagoryId, cascadeDelete: true)
                .Index(t => t.CatagoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductDetails", "CatagoryId", "dbo.Categories");
            DropForeignKey("dbo.OrderDetails", "UserId", "dbo.Registers");
            DropIndex("dbo.ProductDetails", new[] { "CatagoryId" });
            DropIndex("dbo.OrderDetails", new[] { "UserId" });
            DropTable("dbo.ProductDetails");
            DropTable("dbo.Registers");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Categories");
        }
    }
}
