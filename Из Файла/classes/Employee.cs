using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Из_Файла.classes
{
    internal class Employee
    {
        public string name;
        Agreement agreement { get; set; }
        public Employee(string name)
        {
            this.name = name;
        }   
    }
}
