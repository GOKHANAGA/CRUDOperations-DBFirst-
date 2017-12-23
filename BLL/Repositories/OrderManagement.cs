using Model_Entity_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class OrderManagement
    {

        DAL.Repositories.OrderManagement _orderManager = new DAL.Repositories.OrderManagement();
        DAL.Repositories.OrderDetailsManagement _orderDetailsManager = new DAL.Repositories.OrderDetailsManagement();

        //C
        public void AddOrder(Orders entity)
        {
            _orderManager.AddOrder(entity);
        }

        //R
        public List<Orders> GetOrders()
        {
            return _orderManager.GetOrder();
        }

        public Orders GetByID(int entityID)
        {
            return _orderManager.GetByID(entityID);
        }

        //U

        public void UpdateOrder(Orders entity)
        {
            _orderManager.Update(entity);
        }

        //D
        public void Delete(Orders entity)
        {
            _orderDetailsManager.DeleteOrderDetailsByOrderID(entity.OrderID);
            _orderManager.Delete(entity);
        }



    }
}
