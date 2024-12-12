using Из_Файла.classes;
namespace file
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание из файла:");
            Task1();
        }

        static void Task1()
        {
            /*На совещании у начальства раздавали задачи. Сотрудники фирмы так задолбались, что
            решили, что будут получать задачи только в том случае, если это их прямое руководство.
            Все возмущение началось из‐за того, что бухгалтерия решила автоматизировать себе работу,
            они хотят приходить на работу, нажимать на кнопочку и чтобы все само делалось, а отдел
            информационных технологий должен сделать эту задачу им.*/

            Employee timur = new Employee("Тимур", "Генеральный директор", null);
            Employee rashid = new Employee("Рашид", "Финансовый директор", new List<Employee> { timur });
            Employee ilham = new Employee("Ильхам", "Директор по автоматизации", new List<Employee> { timur });

            Employee lukas = new Employee("Лукас", "Главный бухгалтер", new List<Employee> { rashid });

            Employee arkady = new Employee("Оркадий", "Начальник ИТ отдела", new List<Employee> { ilham });
            Employee volodya = new Employee("Володя", "Зам. начальника ИТ отдела", new List<Employee> { ilham });

            Employee ilshat = new Employee("Ильшат", "Главный системщик", new List<Employee> { arkady, volodya });
            Employee ivanych = new Employee("Иваныч", "Зам. системщика", new List<Employee> { ilshat });
            Employee ilya = new Employee("Илья", "Системщик", new List<Employee> { ivanych });
            Employee vitia = new Employee("Витя", "Системщик", new List<Employee> { ivanych });
            Employee zhenya = new Employee("Женя", "Системщик", new List<Employee> { ivanych });

            Employee sergey = new Employee("Сергей", "Главный разработчик", new List<Employee> { arkady, volodya });
            Employee laisan = new Employee("Ляйсан", "Зам. главного разработчика", new List<Employee> { sergey });
            Employee marat = new Employee("Марат", "Разработчик", new List<Employee> { laisan });
            Employee dina = new Employee("Дина", "Разработчик", new List<Employee> { laisan });
            Employee ildar = new Employee("Ильдар", "Разработчик", new List<Employee> { laisan });
            Employee anton = new Employee("Антон", "Разработчик", new List<Employee> { laisan });

            Tasks task1 = new Tasks("Диагностика сети", TaskType.SystemAdmins);
            Tasks task2 = new Tasks("Разработать новую программу", TaskType.Developers); 
            Tasks task3 = new Tasks("Отдыхать", TaskType.Management);
            Tasks task4 = new Tasks("Перезагрузка сети", TaskType.SystemAdmins);

            AssignTask(task1, ivanych, vitia);
            AssignTask(task2, sergey, marat);
            AssignTask(task3, timur, rashid);
            AssignTask(task4, anton, laisan);
        }
        static void AssignTask(Tasks task, Employee fromEmployee, Employee toEmployee)
        {
            Console.WriteLine($"\n{fromEmployee.Position} {fromEmployee.Name} дает задачу \"{task.Description}\", типа {task.Type}, сотруднику {toEmployee.Position} {toEmployee.Name}");

            if (toEmployee.TakesTask(fromEmployee))
            {
                Console.WriteLine($"Сотрудник {toEmployee.Name} принимает задачу.");
            }
            else
            {
                Console.WriteLine($"Сотрудник {toEmployee.Name} не принимает задачу.");
            }
        }
    }
    public enum TaskType
    {
        SystemAdmins,
        Developers,
        Management
    }
}