using Model_Entity_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CategoryManagement
    {
        NORTHWNDEntities dB = new NORTHWNDEntities();
        
        /*C*/
        public void AddCategory(Categories entity)
        {
            dB.Categories.Add(entity);
            dB.SaveChanges();
        }

        /*D*/
        public void RemoveCategory(Categories entity)
        {
            dB.Categories.Remove(entity);
            dB.SaveChanges();
        }

        /*U*/
        public void UpdateCategory(Categories entity)
        {
            Categories categoryToUpdate = GetByID(entity.CategoryID);
            categoryToUpdate.CategoryName = entity.CategoryName;
            categoryToUpdate.Description = entity.Description;
            categoryToUpdate.Picture = entity.Picture;
            dB.SaveChanges();
        }

        /*R*/
        public Categories GetByID(int entityID)
        {
            return dB.Categories.Find(entityID);
        }

        public List<Categories> GetCategories()
        {
            return dB.Categories.ToList();
        }
    }
}
