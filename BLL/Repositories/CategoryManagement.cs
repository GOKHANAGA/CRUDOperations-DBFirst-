using Model_Entity_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class CategoryManagement
    {
       DAL.Repositories.CategoryManagement _categoryManagerDAL = new DAL.Repositories.CategoryManagement();
       DAL.Repositories.ProductManagement _productManagerDAL = new DAL.Repositories.ProductManagement();
       DAL.Repositories.OrderDetailsManagement _orderDetailsmanagerDAL = new DAL.Repositories.OrderDetailsManagement();
        //C
       public void AddCategory(Categories entity)
       {
           _categoryManagerDAL.AddCategory(entity);
       }

        //R
       public Categories GetByID(int entityID)
       {
           return _categoryManagerDAL.GetByID(entityID);
       }

        //R
       public List<Categories> GetCategories()
       {
           return _categoryManagerDAL.GetCategories();
       }

        //U
       public void UpdateCategory(Categories entity)
       {
           _categoryManagerDAL.UpdateCategory(entity);
       }

        //D
       public void RemoveCategory(Categories entity)
       {
           _orderDetailsmanagerDAL.DeleteOrderDetailsByCategoryID(entity.CategoryID);
           _productManagerDAL.DeleteProductByCategoryID(entity.CategoryID);
           _categoryManagerDAL.RemoveCategory(entity);
       }

    }
}
