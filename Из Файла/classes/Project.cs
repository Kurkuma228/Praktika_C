using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Из_Файла.classes
{
    internal class Project
    {
        string description;
        DateTime deadLine;
        string customer;
        Employee teamlead;
        List<Tasks> tasks;
        public ProjectStatus status;

        public Project(DateTime deadLine, string description, string customer, Employee teamlead, List<Tasks> tasks, ProjectStatus status)
        {
            this.description = description;
            this.deadLine = deadLine;
            this.customer = customer;
            this.teamlead = teamlead;
            this.tasks = tasks;
            this.status = status;
        }
    }
}
