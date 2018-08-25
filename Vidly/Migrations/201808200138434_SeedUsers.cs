namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2b5ce4be-bfa9-40e8-956f-e304056518d2', N'guest@vidly.com', 0, N'ADNqxDmOpSiW+IFrlyB6gAllLA9RdxglR5pDgzrBp1zcrigbqhEgjEI2nMuWMJaqfg==', N'6afe6185-867d-41b5-9acb-b47c3c1b4ecf', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e66a033a-7b8d-4a06-a3f2-7b2f36ab6128', N'admin@vidly.com', 0, N'AB09rmdkYA6ocYfN5OscSWtxtcovhanNqaSqdRwWc0lCbhn5eLMMXZFXTqsBbUJZjg==', N'a9f2f2ab-7e06-4d6a-a03f-6f564c9326d3', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4ec9afc6-444b-487a-9da4-fdc69bfb2fab', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e66a033a-7b8d-4a06-a3f2-7b2f36ab6128', N'4ec9afc6-444b-487a-9da4-fdc69bfb2fab')
");
        }
        
        public override void Down()
        {
        }
    }
}
