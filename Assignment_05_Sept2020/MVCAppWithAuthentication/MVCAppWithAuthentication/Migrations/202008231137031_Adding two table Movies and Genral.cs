namespace MVCAppWithAuthentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingtwotableMoviesandGenral : DbMigration
    {
        public override void Up()
        {

            CreateTable(
               "dbo.Movies",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Name = c.String(nullable: false),
                   MovieType = c.String(nullable: false),
               })
               .PrimaryKey(t => t.Id);

            AddColumn("dbo.Movies", "Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "Id");
            AddForeignKey("dbo.Movies", "Id", "dbo.General", "GenreId", cascadeDelete: true);

            CreateTable(
               "dbo.Generals",
               c => new
               {
                   GenreId = c.Int(nullable: false, identity: true),
                   GName = c.String(nullable: false),
               })
               .PrimaryKey(t => t.GenreId);
        }
        
        public override void Down()
        {
        }
    }
}
