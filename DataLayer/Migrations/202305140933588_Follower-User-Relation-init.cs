namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FollowerUserRelationinit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Followers",
                c => new
                    {
                        FId = c.Int(nullable: false, identity: true),
                        DateFollowed = c.DateTime(nullable: false),
                        FollowedUserName = c.String(),
                        FollowerUserId = c.Int(),
                    })
                .PrimaryKey(t => t.FId)
                .ForeignKey("dbo.Users", t => t.FollowerUserId)
                .Index(t => t.FollowerUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Followers", "FollowerUserId", "dbo.Users");
            DropIndex("dbo.Followers", new[] { "FollowerUserId" });
            DropTable("dbo.Followers");
        }
    }
}
