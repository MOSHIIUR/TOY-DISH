using AutoMapper;
using BusinessLayer.DTOs;
using DataLayer.Manager;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class GameService
    {
        public static List<GameDTO> Get()
        {
            return convert(DataAccess.GameData().Get());
        }

        public static GameDTO Get(int id)
        {
            return convert(DataAccess.GameData().Get(id));
        }

        public static List<Game> Get10()
        {
            var data = (from e in DataAccess.GameData().Get()
                        where e.GameId < 11
                        select e).ToList();
            return data;
        }

        public static bool Create(GameDTO game)
        {
            var data = convert(game); //convert DTO to game

            var res = DataAccess.GameData().Insert(data); //pass to data layer

            //pass result to app layer
            if (res) return true;
            else return false;


        }

        public static bool Update(GameDTO game)
        {
            var data = convert(game); //convert DTO to game

            var res = DataAccess.GameData().Update(data); //pass to data layer

            //pass result to app layer
            if (res) return true;
            else return false;
        }
        public static bool Delete(int id)
        {
            return DataAccess.GameData().Delete(id);
        }

        public static GameCommentDTO GetwithComments(int id)
        {
            var data = DataAccess.GameData().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Game, GameCommentDTO>();
                c.CreateMap<Comment, CommentDTO>();
                c.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<GameCommentDTO>(data);
            return mapped;

        }


        //take list of Game return GameDTO
        static List<GameDTO> convert(List<Game> categories)
        {
            var data = new List<GameDTO>();
            foreach (var g in categories)
            {
                data.Add(new GameDTO
                {
                    GameId = g.GameId,
                    GameTitle = g.GameTitle,
                    GameDescription = g.GameDescription,
                    GameDownloadLink = g.GameDownloadLink,
                    GamePlatform = g.GamePlatform,
                    GamePrice = g.GamePrice,
                    PostAt = g.PostAt
                });
            }

            return data;
        }

        //take a Game and retun it's dto
        static GameDTO convert(Game g)
        {
            return new GameDTO()
            {
                GameId = g.GameId,
                GameTitle = g.GameTitle,
                GameDescription = g.GameDescription,
                GameDownloadLink = g.GameDownloadLink,
                GamePlatform = g.GamePlatform,
                GamePrice = g.GamePrice,
                PostAt = g.PostAt
            };
        }

        //take a GameDTO and retun just the Game
        static Game convert(GameDTO g)
        {
            return new Game()
            {
                GameId = g.GameId,
                GameTitle = g.GameTitle,
                GameDescription = g.GameDescription,
                GameDownloadLink = g.GameDownloadLink,
                GamePlatform = g.GamePlatform,
                GamePrice = g.GamePrice,
                PostAt = g.PostAt
            };
        }

    }
}
