using Model_Entity_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class ProductManagement
    {
        DAL.Repositories.ProductManagement _productManager = new DAL.Repositories.ProductManagement();
        DAL.Repositories.OrderDetailsManagement _orderDetailsManager = new DAL.Repositories.OrderDetailsManagement();


        //C
        public void AddProduct(Products entity)
        {
            _productManager.AddProduct(entity);
        }


        //R
        public Products GetByID(int entitytID)
        {
           return _productManager.GetByID(entitytID);
        }

        public List<Products> GetProducts()
        {
            return _productManager.GetProducts();
        }

        //U
        public void UpdateProduct(Products entity)
        {
            _productManager.UpdateProduct(entity);
        }

        //D

        public void Delete(Products entity)
        {
            _orderDetailsManager.DeleteOrderDetailsByProductID(entity.ProductID);
            _productManager.Delete(entity);
        }

        public void DeleteProductByCategoryID(int categoryId)
        {
            _productManager.DeleteProductByCategoryID(categoryId);
        }


    }
}
