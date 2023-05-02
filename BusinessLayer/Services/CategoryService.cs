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
    public class CategoryService
    {
         public static List<CategoryDTO> Get()
        {
            return convert(DataAccess.CategoryData().Get());
        }

        public static CategoryDTO Get(int id)
        {
            return convert(DataAccess.CategoryData().Get(id));
        }

        public static List<Category> Get10()
        {
            var data = (from e in DataAccess.CategoryData().Get()
                        where e.Id < 11
                        select e).ToList();
            return data;
        }

        public static bool Create(CategoryDTO category)
        {
            var data = convert(category); //convert DTO to category

            var res = DataAccess.CategoryData().Insert(data); //pass to data layer

            //pass result to app layer
            if (res) return true;
            else return false;

            
        }

        public static bool Update(CategoryDTO category)
        {
            var data = convert(category); //convert DTO to category

            var res = DataAccess.CategoryData().Update(data); //pass to data layer

            //pass result to app layer
            if (res) return true;
            else return false;
        }
        public static bool Delete(int id)
        {
            return DataAccess.CategoryData().Delete(id);
        }

        //take list of Category return CategoryDTO
        static List<CategoryDTO> convert(List<Category> categories)
        {
            var data = new List<CategoryDTO>();
            foreach (var cat in categories)
            {
                data.Add(new CategoryDTO{ 
                Id = cat.Id,
                CategoryName = cat.CategoryName
                });
            }

            return data;
        }

        //take a category and retun it's dto
        static CategoryDTO convert(Category category)
        {
            return new CategoryDTO()
            {
                Id = category.Id,
                CategoryName = category.CategoryName
            };
        }

        //take a CategoryDTO and retun just the Category
        static Category convert(CategoryDTO category)
        {
            return new Category()
            {
                Id = category.Id,
                CategoryName = category.CategoryName
            };
        }
    }
}
