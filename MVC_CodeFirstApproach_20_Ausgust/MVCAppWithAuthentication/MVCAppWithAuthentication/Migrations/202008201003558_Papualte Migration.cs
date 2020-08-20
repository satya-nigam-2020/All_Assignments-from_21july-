namespace MVCAppWithAuthentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PapualteMigration : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into MemberShipTypes(SignUpFree, DurationInMonths, " +
                "DiscountRate) values (0,0,0)");
            Sql("Insert into MemberShipTypes(SignUpFree, DurationInMonths, " +
               "DiscountRate) values (1,2,3)");
            Sql("Insert into MemberShipTypes(SignUpFree, DurationInMonths, " +
               "DiscountRate) values (10,1,20)");
            Sql("Insert into MemberShipTypes(SignUpFree, DurationInMonths, " +
               "DiscountRate) values (100,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
