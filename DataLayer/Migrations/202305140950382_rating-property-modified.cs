namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ratingpropertymodified : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Ratings", name: "BouhgtBy", newName: "RatedBy");
            RenameIndex(table: "dbo.Ratings", name: "IX_BouhgtBy", newName: "IX_RatedBy");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Ratings", name: "IX_RatedBy", newName: "IX_BouhgtBy");
            RenameColumn(table: "dbo.Ratings", name: "RatedBy", newName: "BouhgtBy");
        }
    }
}
