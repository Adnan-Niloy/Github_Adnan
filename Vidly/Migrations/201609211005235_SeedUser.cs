namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5b7b9d66-9089-4624-8942-71d5d84f7a1d', N'admin@vidly.com', 0, N'ANb5qeUgJLunocYUUumjHS+rEYTGed+chqH22y1MmF4ZryYBViWFXBvvbLnPXzwJ4Q==', N'f35b5718-caf5-45d4-b135-6af81a3c95f4', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8004c366-b6f0-4912-ad5b-e5ecb81e76e2', N'guest@vidly.com', 0, N'AAg27UwTn7IK9JnSxldosp47kV5Swh4nphD5LjOheAmTuCpqbVIm63cLetPk0BulKA==', N'd7c1140b-c076-46e7-b946-7441f527ba9e', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1b5fa757-42ad-4438-a195-389904592c9f', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5b7b9d66-9089-4624-8942-71d5d84f7a1d', N'1b5fa757-42ad-4438-a195-389904592c9f')


");
        }

        public override void Down()
        {
        }
    }
}
