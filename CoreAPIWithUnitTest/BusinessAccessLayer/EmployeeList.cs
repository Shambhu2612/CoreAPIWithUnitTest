using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessAccessLayer
{
    public class EmployeeList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public static List<EmployeeList> EmployeeLists()
        {

            return new List<EmployeeList>() { 
                new EmployeeList {Id=101,Name="Sam",Department="IT"},
                new EmployeeList {Id=102,Name="Roy",Department="HR"},
                new EmployeeList {Id=103,Name="Tom",Department="Payroll"}
            };
        }
    }
}
