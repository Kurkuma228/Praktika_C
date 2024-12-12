using file;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Из_Файла.classes
{
    public class Tasks
    {
        public string Description { get; set; }
        public TaskType Type { get; set; }

        public Tasks(string description, TaskType type)
        {
            Description = description;
            Type = type;
        }
    }
}
