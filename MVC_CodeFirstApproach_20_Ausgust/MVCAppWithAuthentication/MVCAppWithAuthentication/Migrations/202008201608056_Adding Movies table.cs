namespace MVCAppWithAuthentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMoviestable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "MovieType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "MovieType");
        }
    }
}
