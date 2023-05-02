using DataLayer.Interface;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repo
{
    class GameRepo : dBinstance, iRepo<Game, int, bool>
    {
        
        public List<Game> Get()
        {
            return db.Games.ToList();
        }

        public Game Get(int id)
        {
            return db.Games.Find(id);
        }

        public bool Insert(Game data)
        {
            db.Games.Add(data);
            return db.SaveChanges() > 0;
        }

        public bool Update(Game game)
        {
            var newC = db.Games.Find(game.GameId);
            db.Entry(newC).CurrentValues.SetValues(game);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var newC = db.Games.Find(id);
            if (newC != null)
            {
                db.Games.Remove(newC);
                return db.SaveChanges() > 0;
            }

            else return false;
        }
    }
}
