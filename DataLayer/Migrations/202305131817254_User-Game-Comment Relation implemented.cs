namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserGameCommentRelationimplemented : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "CommentedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Comments", "GameId", c => c.Int(nullable: false));
            AddColumn("dbo.Games", "PostedBy", c => c.Int(nullable: false));
            CreateIndex("dbo.Comments", "CommentedBy");
            CreateIndex("dbo.Comments", "GameId");
            CreateIndex("dbo.Games", "PostedBy");
            AddForeignKey("dbo.Games", "PostedBy", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Comments", "GameId", "dbo.Games", "GameId", cascadeDelete: true);
            AddForeignKey("dbo.Comments", "CommentedBy", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "CommentedBy", "dbo.Users");
            DropForeignKey("dbo.Comments", "GameId", "dbo.Games");
            DropForeignKey("dbo.Games", "PostedBy", "dbo.Users");
            DropIndex("dbo.Games", new[] { "PostedBy" });
            DropIndex("dbo.Comments", new[] { "GameId" });
            DropIndex("dbo.Comments", new[] { "CommentedBy" });
            DropColumn("dbo.Games", "PostedBy");
            DropColumn("dbo.Comments", "GameId");
            DropColumn("dbo.Comments", "CommentedBy");
        }
    }
}
