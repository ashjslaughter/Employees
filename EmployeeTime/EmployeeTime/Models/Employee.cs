using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeTime.Models
{
    public class Employee
    {
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public int MyProperty { get; set; }

        public virtual Position Positon { get; set; }
        public virtual Department Department { get; set; }
    }
}