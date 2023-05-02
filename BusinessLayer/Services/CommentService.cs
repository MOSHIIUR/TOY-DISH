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
    public class CommentService
    {
        public static List<CommentDTO> Get()
        {
            return convert(DataAccess.CommentData().Get());
        }

        public static CommentDTO Get(int id)
        {
            return convert(DataAccess.CommentData().Get(id));
        }

        public static List<Comment> Get10()
        {
            var data = (from e in DataAccess.CommentData().Get()
                        where e.CommentId < 11
                        select e).ToList();
            return data;
        }

        public static bool Create(CommentDTO cmnt)
        {
            var data = convert(cmnt); //convert DTO to category

            var res = DataAccess.CommentData().Insert(data); //pass to data layer

            //pass result to app layer
            if (res) return true;
            else return false;


        }

        public static bool Update(CommentDTO cmnt)
        {
            var data = convert(cmnt); //convert DTO to category

            var res = DataAccess.CommentData().Update(data); //pass to data layer

            //pass result to app layer
            if (res) return true;
            else return false;
        }
        public static bool Delete(int id)
        {
            return DataAccess.CommentData().Delete(id);
        }

        //take list of Category return CategoryDTO
        static List<CommentDTO> convert(List<Comment> cmnt)
        {
            var data = new List<CommentDTO>();
            foreach (var c in cmnt)
            {
                data.Add(new CommentDTO
                {
                    CommentId = c.CommentId,
                    CommentText = c.CommentText,
                    CommentAt = c.CommentAt
                });
            }

            return data;
        }

        //take a category and retun it's dto
        static CommentDTO convert(Comment cmnt)
        {
            return new CommentDTO()
            {
                CommentId = cmnt.CommentId,
                CommentText = cmnt.CommentText,
                CommentAt = cmnt.CommentAt
            };
        }

        //take a CategoryDTO and retun just the Category
        static Comment convert(CommentDTO cmnt)
        {
            return new Comment()
            {
                CommentId = cmnt.CommentId,
                CommentText = cmnt.CommentText,
                CommentAt = cmnt.CommentAt
            };
        }

    }
}
