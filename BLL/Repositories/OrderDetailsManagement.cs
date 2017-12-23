using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class OrderDetailsManagement
    {
        DAL.Repositories.OrderDetailsManagement _orderDetailsManager = new DAL.Repositories.OrderDetailsManagement();

        public void DeleteOrderDetailsByCategoryID(int categoryID)
        {
            _orderDetailsManager.DeleteOrderDetailsByCategoryID(categoryID);
        }
    }
}
