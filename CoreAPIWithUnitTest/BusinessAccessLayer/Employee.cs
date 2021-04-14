using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessAccessLayer
{
    public class Employee
    {
        public string GetEmployees(int id)
        {
            var data = (from t in EmployeeList.EmployeeLists()
                       where t.Id == id
                       select t.Name).FirstOrDefault();
            return data;
        }
    }
}
