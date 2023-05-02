namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gamescommentstableinit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        CommentText = c.String(nullable: false),
                        CommentAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CommentId);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        GameTitle = c.String(nullable: false),
                        GameDescription = c.String(nullable: false),
                        GamePrice = c.Int(nullable: false),
                        GamePlatform = c.String(nullable: false),
                        GameDownloadLink = c.String(nullable: false),
                        PostAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.GameId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Games");
            DropTable("dbo.Comments");
        }
    }
}
