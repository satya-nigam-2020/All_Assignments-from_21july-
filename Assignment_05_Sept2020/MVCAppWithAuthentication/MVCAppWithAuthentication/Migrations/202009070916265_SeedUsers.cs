namespace MVCAppWithAuthentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
               INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3e7dcabd-da6f-430b-96da-6df07e7bc4d5', N'satya@gmail.com', 0, N'AMUwvtSZQA+Dc8ORqJ6QuCE6v6XHp0he+TrYl35V00K/uAT5WEH7zJViJdzsgocfWA==', N'7bfdff85-7961-4be5-8cc4-db4980ad9426', NULL, 0, 0, NULL, 1, 0, N'satya@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'885a39c5-1e6f-4830-b78a-346cd9146935', N'satyaprakashnigan.spn@gmail.com', 0, N'AN6cXIrwmWXJIYb/1LjneZO+I/6neFHorGmSP7xI6X5xRt4N1w+gt1RJX+9tF0af+w==', N'263a51ae-3dec-4e8e-9698-2d7724c48df9', NULL, 0, 0, NULL, 1, 0, N'satyaprakashnigan.spn@gmail.com')


                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'99335f7d-f527-4930-82cb-7db24da69f80', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3e7dcabd-da6f-430b-96da-6df07e7bc4d5', N'99335f7d-f527-4930-82cb-7db24da69f80')


");

            
        }
        
        public override void Down()
        {
        }
    }
}
