namespace BethanyPieShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingImagepropinProductDetailtable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductDetails", "Image", c => c.Binary(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductDetails", "Image");
        }
    }
}
