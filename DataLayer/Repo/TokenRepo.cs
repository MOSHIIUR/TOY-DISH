using DataLayer.Interface;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repo
{
    internal class TokenRepo : dBinstance, iRepo<Token, string, Token>
    {

        public Token Get(string id)
        {
            return db.Tokens.FirstOrDefault(t => t.TKey.Equals(id));
        }

        public Token Insert(Token obj)
        {
            db.Tokens.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Token Update(Token obj)
        {
            var token = Get(obj.TKey);
            db.Entry(token).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return token;
            return null;
        }

        public bool Delete(string id)
        {
            var Tobj =  db.Tokens.FirstOrDefault(t => t.TKey.Equals(id));
            if (Tobj != null)
            {
                db.Tokens.Remove(Tobj);
                return db.SaveChanges() > 0;
            }

            else return false;
        }

        public List<Token> Get()
        {
            throw new NotImplementedException();
        }

    }
}
