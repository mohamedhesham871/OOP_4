using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Aggregation
{
    internal class Department
    {
        public int ID { set; get; }
        public required string Name { set; get; }
        // aggregation   it's Optianl
        public List<Employee>? employees { get; set; }
    }
}
