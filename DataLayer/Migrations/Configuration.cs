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

            //Random random = new Random();

            //seeding for User table
            //for (int i = 1; i <= 11; i++)
            //{
            //    context.Users.AddOrUpdate(
            //        new DataLayer.Models.User()
            //        {
            //           UserName = Guid.NewGuid().ToString().Substring(1, 10),
            //           Email = Guid.NewGuid().ToString().Substring(1, 6),
            //           Password = Guid.NewGuid().ToString().Substring(1, 8),
            //           UserType = "General"
            //        }

            //    );

            //}

            //for (int i = 0; i < 15; i++)
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
            //            PostedBy = random.Next(1, 11),


            //        });
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    context.Comments.AddOrUpdate(
            //        new DataLayer.Models.Comment()
            //        {
            //            CommentText = Guid.NewGuid().ToString().Substring(0, 30),
            //            CommentAt = DateTime.Now,
            //            CommentedBy = random.Next(1, 11),
            //            GameId = random.Next(103, 130),
            //        }

            //    );

            //}

            //seeding for Category table
            //for (int i = 1; i <= 10; i++)
            //    {
            //        context.Categories.AddOrUpdate(
            //            new DataLayer.Models.Category()
            //            {
            //                CategoryName = Guid.NewGuid().ToString().Substring(1, 5),
            //            }

            //        );

            //    }

            //for (int i = 1; i <= 20; i++)
            //{
            //    context.Ratings.AddOrUpdate(
            //        new DataLayer.Models.Rating()
            //        {

            //            RatedBy = random.Next(1, 12),
            //            GameId = random.Next(103, 130),
            //            Value = random.Next(1, 10),
            //        }

            //    );

            //}


            //for (int i = 1; i <= 20; i++)
            //{
            //    context.Transactions.AddOrUpdate(
            //        new DataLayer.Models.Transaction()
            //        {

            //            BouhgtBy = random.Next(1, 12),
            //            GameId = random.Next(103, 130),
            //            Price = random.Next(1, 1000),
            //            Time = DateTime.Now.AddDays(random.Next(1, 10)),
            //        }

            //    );

            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    context.Followers.AddOrUpdate(
            //        new DataLayer.Models.Follower()
            //        {

            //            FollowerUserId = random.Next(1, 12),
            //            FollowedUserName = Guid.NewGuid().ToString().Substring(1, 10),
            //            DateFollowed = DateTime.Now.AddDays(random.Next(1, 10)),
            //        }

            //    );

            //}




        }
    }
}
