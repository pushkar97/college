namespace College.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedAdmin : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ceac26aa-521b-49a7-8c2a-0ae6f40ce803', N'admin@college.com', 0, N'AISzKbX4jhyf1u7T8hZDUpd+pY0AgSlfZzNbyzi3ZhjiRGZUqKOXUr6CAzQQ7DJbpQ==', N'c9fc29a5-2629-44ce-a671-bf481b7933c4', NULL, 0, 0, NULL, 1, 0, N'admin@college.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3f01fd47-bd9e-4dc4-b01d-a78902678922', N'CanManageData')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ceac26aa-521b-49a7-8c2a-0ae6f40ce803', N'3f01fd47-bd9e-4dc4-b01d-a78902678922')
");
        }
        
        public override void Down()
        {
        }
    }
}
