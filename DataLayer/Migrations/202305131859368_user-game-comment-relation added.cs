namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usergamecommentrelationadded : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Users");
            DropColumn("dbo.Users", "Id");

            AddColumn("dbo.Comments", "CommentedBy", c => c.Int());
            AddColumn("dbo.Comments", "GameId", c => c.Int());
            AddColumn("dbo.Games", "PostedBy", c => c.Int());
            AddColumn("dbo.Users", "UserId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Users", "UserName", c => c.String(nullable: false));
            AddColumn("dbo.Users", "UserType", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Users", "UserId");
            CreateIndex("dbo.Comments", "CommentedBy");
            CreateIndex("dbo.Comments", "GameId");
            CreateIndex("dbo.Games", "PostedBy");
            AddForeignKey("dbo.Games", "PostedBy", "dbo.Users", "UserId");
            AddForeignKey("dbo.Comments", "GameId", "dbo.Games", "GameId");
            AddForeignKey("dbo.Comments", "CommentedBy", "dbo.Users", "UserId");
            DropColumn("dbo.Users", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Comments", "CommentedBy", "dbo.Users");
            DropForeignKey("dbo.Comments", "GameId", "dbo.Games");
            DropForeignKey("dbo.Games", "PostedBy", "dbo.Users");
            DropIndex("dbo.Games", new[] { "PostedBy" });
            DropIndex("dbo.Comments", new[] { "GameId" });
            DropIndex("dbo.Comments", new[] { "CommentedBy" });
            DropPrimaryKey("dbo.Users");
            DropColumn("dbo.Users", "UserType");
            DropColumn("dbo.Users", "UserName");
            DropColumn("dbo.Users", "UserId");
            DropColumn("dbo.Games", "PostedBy");
            DropColumn("dbo.Comments", "GameId");
            DropColumn("dbo.Comments", "CommentedBy");
            AddPrimaryKey("dbo.Users", "Id");
        }
    }
}
