namespace DataLayer.Migrations
{
    using DataLayer.Repo;
    using DataLayer.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataLayer.dBCC>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataLayer.dBCC context)
        {
            //seeding for comment table
            //for (int i = 1; i <= 10; i++)
            //{
            //    context.Comments.AddOrUpdate(
            //        new DataLayer.Models.Comment()
            //        {
            //            CommentText = Guid.NewGuid().ToString().Substring(0, 30),
            //            CommentAt = DateTime.Now,
            //        }

            //    );

            //}

            //games seeding
            //Random random = new Random();
            //for (int i = 0; i < 100; i++)
            //{
            //    context.Games.AddOrUpdate(
            //        new DataLayer.Models.Game()
            //        {
            //            GameTitle = Guid.NewGuid().ToString().Substring(1, 8),
            //            GameDescription = Guid.NewGuid().ToString().Substring(1, 30),
            //            GamePlatform = Guid.NewGuid().ToString().Substring(1, 5),
            //            GameDownloadLink = Guid.NewGuid().ToString().Substring(1, 5),
            //            GamePrice = random.Next(100, 1000),
            //            PostAt = DateTime.Now,

            //        });
            //}
        }
    }
}
