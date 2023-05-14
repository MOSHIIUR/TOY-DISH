namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GameHasaCategoryrelationinit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "CategoryId", c => c.Int());
            CreateIndex("dbo.Games", "CategoryId");
            AddForeignKey("dbo.Games", "CategoryId", "dbo.Categories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Games", new[] { "CategoryId" });
            DropColumn("dbo.Games", "CategoryId");
        }
    }
}
