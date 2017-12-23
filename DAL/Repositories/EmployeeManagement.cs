using Model_Entity_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EmployeeManagement
    {
        NORTHWNDEntities dB=new NORTHWNDEntities();


        //C
        public void AddEmployee(Employees entity)
        {
            dB.Employees.Add(entity);
            dB.SaveChanges();
        }

        //R

        public Employees GetByID(int entityID)
        {
            return dB.Employees.Find(entityID);
        }

        public List<Employees> GetEmployees()
        {
            return dB.Employees.ToList();
        }

        //U
        public void UpdateEmployee(Employees entity)
        {
            Employees emp = GetByID(entity.EmployeeID);
            emp.City = entity.City;
            emp.Country = entity.Country;
            dB.SaveChanges();
        }

        //D
        public void Delete(Employees entity)
        {
            dB.Employees.Remove(entity);
            dB.SaveChanges();
        }


    }
}
