using Model_Entity_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProductManagement
    {
        NORTHWNDEntities dB = new NORTHWNDEntities();
 
        //C
        public void AddProduct(Products entity)
        {
            dB.Products.Add(entity);
            dB.SaveChanges();
        }

        //D

        public void Delete(Products entity)
        {
            dB.Products.Remove(entity);
            dB.SaveChanges();
        }

        public void DeleteProductByCategoryID(int categoryID)
        {
            //Delete products of given category id
            dB.Products.RemoveRange(dB.Products.Where(product => product.CategoryID == categoryID));
            dB.SaveChanges();
        }

        //U

        public void UpdateProduct(Products entity)
        {
            Products productToUpdate = GetByID(entity.ProductID);
            productToUpdate.ProductName = entity.ProductName;
            productToUpdate.Discontinued = entity.Discontinued;
            dB.SaveChanges();
        }

        //R
        public Products GetByID(int entityID)
        {
            return dB.Products.Find(entityID);
        }

        public List<Products> GetProducts()
        {
            return dB.Products.ToList();
        }

    }
}
