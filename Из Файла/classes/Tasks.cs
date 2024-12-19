using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Из_Файла.classes
{
    internal class Tasks
    {
        string description;
        public DateTime deadLine;
        Employee customer;
        Employee performer;
        public TaskStatus status;
        List<Reports> reports;

        public Tasks(string description, DateTime deadLine, Employee customer, Employee performer, TaskStatus status, List<Reports> reports)
        {
            this.description = description;
            this.deadLine = deadLine;
            this.customer = customer;
            this.performer = performer;
            this.status = status;
            this.reports = reports;
        }
    }
}
