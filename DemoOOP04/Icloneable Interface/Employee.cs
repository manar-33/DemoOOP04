using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP04.Icloneable_Interface
{
    internal class Employee : ICloneable , IComparable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public object Clone()
        {
            return new Employee() { Id=this.Id, Name=this.Name, Salary=this.Salary};
        }

        public int CompareTo(object? obj)
        {
            Employee Passedemployee = (Employee)obj;
            if (this.Salary > Passedemployee.Salary)
                return 1;
            else if (this.Salary < Passedemployee.Salary)
                return -1;
            else return 0;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name : {Name}, Salary :{Salary}";
        }
    }
}
