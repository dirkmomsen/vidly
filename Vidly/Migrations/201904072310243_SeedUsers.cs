namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5449be02-4bda-4896-a10b-4eec8753b5e0', N'admin@vidly.com', 0, N'AAx9kE2Gi5WCAlZofesuN/tBGJFFeDykMugaSfpXhjayx9hW2CwD46Tpcc56xR8+vA==', N'e035fbb2-4bef-49bf-b9e5-2f51d7c2f900', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f7823c81-41ca-40c4-bd81-0d3dd3b10320', N'guest@vidly.com', 0, N'AHo0XSmtSvt7z6ugrJQqm8m8pOITlAw2h4D2SbCiYiUpXGw6BG1Qq9Pi0H8Bj37phg==', N'19539ca5-3cda-4fbf-9ccc-12725906a85f', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cf5d8fc9-dcb2-4b92-ad0b-46660530b07e', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5449be02-4bda-4896-a10b-4eec8753b5e0', N'cf5d8fc9-dcb2-4b92-ad0b-46660530b07e')
");

        }
        
        public override void Down()
        {
        }
    }
}
