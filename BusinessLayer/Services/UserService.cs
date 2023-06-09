﻿using BusinessLayer.DTOs;
using DataLayer.Manager;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class UserService
    {
        public static List<UserDTO> Get()
        {
            return convert(DataAccess.UserData().Get());
        }

        public static UserDTO Get(int id)
        {
            return convert(DataAccess.UserData().Get(id));
        }

        public static List<User> Get10()
        {
            var data = (from e in DataAccess.UserData().Get()
                        where e.UserId < 11
                        select e).ToList();
            return data;
        }

        public static bool Create(UserDTO user)
        {
            var data = convert(user); //convert DTO to category

            var res = DataAccess.UserData().Insert(data); //pass to data layer

            //pass result to app layer
            if (res) return true;
            else return false;
        }

        public static bool Update(UserDTO user)
        {
            var data = convert(user); //convert DTO to category

            var res = DataAccess.UserData().Update(data); //pass to data layer

            //pass result to app layer
            if (res) return true;
            else return false;
        }
        public static bool Delete(int id)
        {
            return DataAccess.UserData().Delete(id);
        }

        //take list of model return DTO
        static List<UserDTO> convert(List<User> user)
        {
            var data = new List<UserDTO>();
            foreach (var u in user)
            {
                data.Add(new UserDTO
                {
                    Id = u.UserId,
                    Name = u.UserName,
                    Email = u.Email,
                    Password = u.Password,
                    UserType = u.UserType
                });
            }

            return data;
        }

        //take a Model and retun it's dto
        static UserDTO convert(User user)
        {
            return new UserDTO()
            {
                Id = user.UserId,
                Name = user.UserName,
                Email = user.Email,
                Password = user.Password,
                UserType = user.UserType
            };
        }

        //take a DTO and retun just the Model
        static User convert(UserDTO user)
        {
            return new User()
            {
                UserName = user.Name,
                Email = user.Email,
                Password = user.Password,
                UserType = user.UserType
            };
        }
    }
}
