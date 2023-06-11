using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject.EntityLayer
{
    public class Operation
    {
        public int OperationID { get; set; }
        public string Name { get; set; }
        public int Difficulty { get; set; }
        public List<Employee> Employee { get; set; }
    }
}
