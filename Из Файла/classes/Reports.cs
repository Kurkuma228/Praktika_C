using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Из_Файла.classes
{
    internal class Reports
    {
        string description;
        DateTime dateOfCompletion;
        Employee performer;

        public Reports(string description, DateTime dateOfCompletion, Employee performer)
        {
            this.description = description;
            this.dateOfCompletion = dateOfCompletion;
            this.performer = performer;
        }
    }
}
