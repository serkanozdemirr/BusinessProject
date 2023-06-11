using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject.EntityLayer
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int OperationID { get; set; }
        public Operation Operation { get; set; }
    }
}
