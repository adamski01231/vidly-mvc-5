namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3ae945f6-5c55-468c-bff3-f65d32231a02', N'admin@vidly.com', 0, N'ACLkYhrjUpVwgT9bBACT8B539+BEND3UXoo1iOkr3FWHZY7rNUR+OjcXg45i3hkowg==', N'2044bf68-e94f-4148-9638-16a8fa90729b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8ab5b1c9-6972-407f-8afb-62bab4d5c449', N'guest@vidly.com', 0, N'AN9QGAO3/Boe5oY+Czrxt7torREns2+02Vpu6MACTNN+ecAVYPI/MPg6CpWMQrGa/Q==', N'83d40ad3-2214-4a03-9921-ba9603073df8', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c688b36f-3b5c-45fe-8c7c-aa3fb1192db9', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3ae945f6-5c55-468c-bff3-f65d32231a02', N'c688b36f-3b5c-45fe-8c7c-aa3fb1192db9')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
