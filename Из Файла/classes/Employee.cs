using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using file;
namespace Из_Файла.classes
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public List<Employee> Bosses {  get; set; }

        public Employee(string name, string position, List<Employee> bosses)
        {
            Name = name;
            Position = position;
            Bosses = bosses;
        }
        public bool TakesTask(Employee fromEmployer)
        {
            if (Bosses.Contains(fromEmployer))
            {
                return true;
            }
            return false;
        }
    }
}
