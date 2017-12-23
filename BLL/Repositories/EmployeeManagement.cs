using Model_Entity_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class EmployeeManagement
    {
        DAL.Repositories.EmployeeManagement _employeeManager = new DAL.Repositories.EmployeeManagement();
        DAL.Repositories.OrderManagement _orderManager = new DAL.Repositories.OrderManagement();
        DAL.Repositories.OrderDetailsManagement _orderDetailsManager = new DAL.Repositories.OrderDetailsManagement();


        //C
        public void AddEmployee(Employees entity)
        {
            _employeeManager.AddEmployee(entity);
        }

        //R
        public Employees GetByID(int entityID)
        {
           return  _employeeManager.GetByID(entityID);
        }

        public List<Employees> GetEmployees()
        {
            return _employeeManager.GetEmployees();
        }

        //U

        public void UpdateEmployee(Employees entity)
        {
            _employeeManager.UpdateEmployee(entity);
        }

        //D
        public void Delete(Employees entity)
        {
            _orderDetailsManager.DeleteOrderDetailsByEmployeeID(entity.EmployeeID);
            _orderManager.DeleteOrderByEmployeeID(entity.EmployeeID);
            _employeeManager.Delete(entity);
        }

    }
}
