namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TransactionConnectedwithGameUserrelationinit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "BouhgtBy", c => c.Int());
            AddColumn("dbo.Transactions", "GameId", c => c.Int());
            CreateIndex("dbo.Transactions", "BouhgtBy");
            CreateIndex("dbo.Transactions", "GameId");
            AddForeignKey("dbo.Transactions", "GameId", "dbo.Games", "GameId");
            AddForeignKey("dbo.Transactions", "BouhgtBy", "dbo.Users", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "BouhgtBy", "dbo.Users");
            DropForeignKey("dbo.Transactions", "GameId", "dbo.Games");
            DropIndex("dbo.Transactions", new[] { "GameId" });
            DropIndex("dbo.Transactions", new[] { "BouhgtBy" });
            DropColumn("dbo.Transactions", "GameId");
            DropColumn("dbo.Transactions", "BouhgtBy");
        }
    }
}
