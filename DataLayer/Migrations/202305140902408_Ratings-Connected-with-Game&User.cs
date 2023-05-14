namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RatingsConnectedwithGameUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ratings", "BouhgtBy", c => c.Int());
            AddColumn("dbo.Ratings", "GameId", c => c.Int());
            CreateIndex("dbo.Ratings", "BouhgtBy");
            CreateIndex("dbo.Ratings", "GameId");
            AddForeignKey("dbo.Ratings", "GameId", "dbo.Games", "GameId");
            AddForeignKey("dbo.Ratings", "BouhgtBy", "dbo.Users", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ratings", "BouhgtBy", "dbo.Users");
            DropForeignKey("dbo.Ratings", "GameId", "dbo.Games");
            DropIndex("dbo.Ratings", new[] { "GameId" });
            DropIndex("dbo.Ratings", new[] { "BouhgtBy" });
            DropColumn("dbo.Ratings", "GameId");
            DropColumn("dbo.Ratings", "BouhgtBy");
        }
    }
}
