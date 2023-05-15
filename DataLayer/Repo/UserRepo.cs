using DataLayer.Interface;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repo
{
    internal class UserRepo : dBinstance, iRepo<User, int, bool>, IAuth<bool>
    {
            public bool Authenticate(string username, string password)
            {
                var data = db.Users.FirstOrDefault(u => u.UserName.Equals(username) &&
                u.Password.Equals(password));

            var TokenData = db.Tokens.FirstOrDefault(u => u.UserId.Equals(username));
                if (data != null && TokenData == null) return true;

                else return false;
            }
        public List<User> Get()
            {
                return db.Users.ToList();
            }

            public User Get(int id)
            {
                return db.Users.Find(id);
            }

            public bool Insert(User user)
            {
                db.Users.Add(user);
                return db.SaveChanges() > 0;
            }

            public bool Update(User user)
            {
                var newUser = db.Categories.Find(user.UserId);
                db.Entry(newUser).CurrentValues.SetValues(user);
                return db.SaveChanges() > 0;
            }

            public bool Delete(int id)
            {
                var newUser = db.Users.Find(id);
                if (newUser != null)
                {
                    db.Users.Remove(newUser);
                    return db.SaveChanges() > 0;
                }

                else return false;
            }
        
    }
}
