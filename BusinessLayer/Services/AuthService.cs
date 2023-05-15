using DataLayer.Manager;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.DTOs;

namespace BusinessLayer.Services
{
    public class AuthService
    {
        public static TokenDTO Authenticate(string uname, string pass)
        {

            var res = DataAccess.AuthData().Authenticate(uname, pass);
            if (res)
            {
                var token = new Token();
                token.UserId = uname;
                token.CreatedAt = DateTime.Now;
                token.TKey = Guid.NewGuid().ToString();
                var ret = DataAccess.TokenData().Insert(token);
                if (ret != null)
                {
                    var cfg = new MapperConfiguration(c => {
                        c.CreateMap<Token, TokenDTO>();
                    });
                    var mapper = new Mapper(cfg);
                    return mapper.Map<TokenDTO>(ret);
                }

            }
            return null;

        }

        public static bool IsTokenValid(string tkey)
        {
            var extk = DataAccess.TokenData().Get(tkey);
            if (extk != null && extk.DeletedAt == null)
            {
                return true;
            }
            return false;
        }
        public static bool Logout(string tkey)
        {
            var extk = DataAccess.TokenData().Delete(tkey);
            
            if (extk) return true;

            else return false;

        }
        //public static bool IsAdmin(string tkey)
        //{
        //    var extk = DataAccess.TokenData().Get(tkey);
        //    if (IsTokenValid(tkey) && extk.User.Type.Equals("Admin"))
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
