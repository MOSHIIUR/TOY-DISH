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
            //for (int i = 1; i <= 10; i++)
            //{
            //    context.Categories.AddOrUpdate(
            //        new DataLayer.Models.Category()
            //        {
            //            CategoryName = Guid.NewGuid().ToString().Substring(0, 6),
            //        }

            //    );

            //}
        }
    }
}
