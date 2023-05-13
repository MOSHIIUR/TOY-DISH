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
    public class RatingService
    {
        public static List<RatingDTO> Get()
        {
            return convert(DataAccess.RatingData().Get());
        }

        public static RatingDTO Get(int id)
        {
            return convert(DataAccess.RatingData().Get(id));
        }

        public static List<Rating> Get10()
        {
            var data = (from r in DataAccess.RatingData().Get()
                        where r.Id < 11
                        select r).ToList();
            return data;
        }

        public static bool Create(RatingDTO Rating)
        {
            var data = convert(Rating); //convert DTO to Rating

            var res = DataAccess.RatingData().Insert(data); //pass to data layer

            //pass result to app layer
            if (res) return true;
            else return false;


        }

        public static bool Update(RatingDTO Rating)
        {
            var data = convert(Rating); //convert DTO to Rating

            var res = DataAccess.RatingData().Update(data); //pass to data layer

            //pass result to app layer
            if (res) return true;
            else return false;
        }
        public static bool Delete(int id)
        {
            return DataAccess.RatingData().Delete(id);
        }

        //take list of Rating return RatingDTO
        static List<RatingDTO> convert(List<Rating> ratings)
        {
            var data = new List<RatingDTO>();
            foreach (var r in ratings)
            {
                data.Add(new RatingDTO
                {
                    Id = r.Id,
                    Value = r.Value
                });
            }

            return data;
        }

        //take a Rating and retun it's dto
        static RatingDTO convert(Rating rating)
        {
            return new RatingDTO()
            {
                Id = rating.Id,
                Value = rating.Value
            };
        }

        //take a RatingDTO and retun just the Rating
        static Rating convert(RatingDTO rating)
        {
            return new Rating()
            {
                Id = rating.Id,
                Value = rating.Value
            };
        }
    }
}
