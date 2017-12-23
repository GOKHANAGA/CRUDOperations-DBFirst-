using Model_Entity_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class OrderDetailsManagement
    {
        NORTHWNDEntities dB = new NORTHWNDEntities();


        //C
        public void AddOrderDetail(Order_Details entity)
        {
            dB.Order_Details.Add(entity);
            dB.SaveChanges();
        }

        //R
        public List<Order_Details> GetOrderDetails()
        {
           return dB.Order_Details.ToList();
        }

        public Order_Details GetByID(int entityOrderID,int entityProductID)
        {
            return dB.Order_Details.Find(entityOrderID,entityProductID);
        }


        //U
        public void Update(Order_Details entity)
        {
            Order_Details orderDetails = GetByID(entity.OrderID, entity.ProductID);
            orderDetails.Quantity = entity.Quantity;
            orderDetails.UnitPrice = entity.UnitPrice;
            orderDetails.Discount = entity.Discount;

            dB.SaveChanges();
        }


        //D
        public void Delete(Order_Details entity)
        {
            dB.Order_Details.Remove(entity);
            dB.SaveChanges();
        }

        public void DeleteOrderDetailsByCategoryID(int categoryID)
        {
            //Join the order details with the products of given category id and delete these product's order details.
            dB.Order_Details.RemoveRange(dB.Order_Details.Join(dB.Products.Where(pro => pro.CategoryID==categoryID),od => od.ProductID,p=>p.ProductID,(od,p)=> od));
            dB.SaveChanges();

        }

        public void DeleteOrderDetailsByProductID(int productID)
        {
            dB.Order_Details.RemoveRange(dB.Order_Details.Join(dB.Products.Where(product => product.ProductID == productID), od => od.ProductID, p => p.ProductID, (od, p) => od));
            dB.SaveChanges();
        }

        public void DeleteOrderDetailsByOrderID(int orderID)
        {
            dB.Order_Details.RemoveRange(dB.Order_Details.Join(dB.Orders.Where(order => order.OrderID == orderID), od => od.OrderID, o => o.OrderID, (od, o) => od));
            dB.SaveChanges();
        }

        public void DeleteOrderDetailsByEmployeeID(int employeeID)
        {
            dB.Order_Details.RemoveRange(dB.Order_Details.Join(dB.Orders.Where(order => order.EmployeeID == employeeID),od => od.OrderID,or => or.OrderID,(od,or)=>od));
            dB.SaveChanges();
        }

    }
}
