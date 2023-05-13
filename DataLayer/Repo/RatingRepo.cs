using DataLayer.Interface;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repo
{
    internal class RatingRepo : dBinstance, iRepo<Rating,int, bool>
    {
        public List<Rating> Get()
        {
            return db.Ratings.ToList();
        }

        public Rating Get(int id)
        {
            return db.Ratings.Find(id);
        }

        public bool Insert(Rating rating)
        {
            db.Ratings.Add(rating);
            return db.SaveChanges() > 0;
        }

        public bool Update(Rating rating)
        {
            var newRating = db.Categories.Find(rating.Id);
            db.Entry(newRating).CurrentValues.SetValues(rating);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var newRating = db.Ratings.Find(id);
            if (newRating != null)
            {
                db.Ratings.Remove(newRating);
                return db.SaveChanges() > 0;
            }

            else return false;
        }
    }
}
