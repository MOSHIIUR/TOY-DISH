using DataLayer.Interface;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repo
{
    internal class CategoryRepo : dBinstance, iRepo<Category, int, bool>
    {
        public List<Category> Get()
        {
            return db.Categories.ToList();
        }

        public Category Get(int id)
        {
            return db.Categories.Find(id);
        }

        public bool Insert(Category data)
        {
            db.Categories.Add(data);
            return db.SaveChanges() > 0;
        }

        public bool Update(Category category)
        {
            var newC = db.Categories.Find(category.Id);
            db.Entry(newC).CurrentValues.SetValues(category);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var newC = db.Categories.Find(id);
            if (newC != null)
            {
                db.Categories.Remove(newC);
                return db.SaveChanges() > 0;
            }

            else return false;
           
        }
    }
}
