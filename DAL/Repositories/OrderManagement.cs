using Model_Entity_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class OrderManagement
    {
        NORTHWNDEntities dB = new NORTHWNDEntities();

        //C
        public void AddOrder(Orders entity)
        {
            dB.Orders.Add(entity);
            dB.SaveChanges();
        }

        //R
        public List<Orders> GetOrder()
        {
            return dB.Orders.ToList();
        }

        public Orders GetByID(int entityID)
        {
            return dB.Orders.Find(entityID);
        }

        //U

        public void Update(Orders entity)
        {
            Orders order = GetByID(entity.OrderID);
            order.ShipCity = entity.ShipCity;
            order.ShipName = entity.ShipName;

            dB.SaveChanges();
        }

        //D
        public void Delete(Orders entity)
        {
            dB.Orders.Remove(entity);
        }

        public void DeleteOrderByEmployeeID(int employeeID)
        {
            dB.Orders.RemoveRange(dB.Orders.Where(order => order.EmployeeID == employeeID));
            dB.SaveChanges();
        }

    }
}
