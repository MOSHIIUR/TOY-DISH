using DataLayer.Interface;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repo
{
    class CommentRepo : dBinstance, iRepo<Comment, int, bool>
    {
        public bool Delete(int id)
        {
            var newC = db.Comments.Find(id);
            if (newC != null)
            {
                db.Comments.Remove(newC);
                return db.SaveChanges() > 0;
            }

            else return false;
        }

        public List<Comment> Get()
        {
            return db.Comments.ToList();
        }

        public Comment Get(int id)
        {
            return db.Comments.Find(id);
        }

        public bool Insert(Comment cmnt)
        {
            db.Comments.Add(cmnt);
            return db.SaveChanges() > 0;
        }

        public bool Update(Comment cmnt)
        {
            var newC = db.Comments.Find(cmnt.CommentId);
            db.Entry(newC).CurrentValues.SetValues(cmnt);
            return db.SaveChanges() > 0;
        }
    }
}
