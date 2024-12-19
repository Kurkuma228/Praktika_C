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
            Employee teamlead = new Employee("Игорь");
            Employee employee2 = new Employee("Михаил");
            Employee employee3 = new Employee("Алексей");
            Employee employee4 = new Employee("Василий");
            Employee employee5 = new Employee("Сергей");
            Employee employee6 = new Employee("Дарья");
            Employee employee7 = new Employee("Софья");
            Employee employee8 = new Employee("Александр");
            Employee employee9 = new Employee("Екатерина");
            Employee employee10 = new Employee("Пётр");

            List<Tasks> tasks = new List<Tasks>();
            List<Reports> reports = new List<Reports>();
            List<Employee> employees = new List<Employee>{ teamlead, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9};

            DateTime dateTime = DateTime.Now;

            Project project = new Project(dateTime.AddMonths(3), "Создать игру на мобильной платформе", "Дядя Вася", teamlead, tasks, ProjectStatus.Проект);
            
            Tasks task1 = new Tasks("Нести ответственность за проект", dateTime.AddMonths(3), teamlead, teamlead, TaskStatus.Назначена, reports);

            Tasks task2 = new Tasks("Создай диздок по игре", dateTime.AddDays(7), teamlead, employee2, TaskStatus.Назначена, reports);

            Tasks task3 = new Tasks("Написать сюжет игры", dateTime.AddDays(30), teamlead, employee3, TaskStatus.Назначена, reports);

            Tasks task4 = new Tasks("Придумать геймплэй игры", dateTime.AddDays(30), teamlead, employee4, TaskStatus.Назначена, reports);

            Tasks task5 = new Tasks("Создать объекты для игры", dateTime.AddDays(60), teamlead, employee5, TaskStatus.Назначена, reports);

            Tasks task6 = new Tasks("Создать персонажей", dateTime.AddDays(30), teamlead, employee6, TaskStatus.Назначена, reports);

            Tasks task7 = new Tasks("Настроить монетизацию", dateTime.AddDays(60), teamlead, employee7, TaskStatus.Назначена, reports);

            Tasks task8 = new Tasks("Настроить сервера", dateTime.AddDays(20), teamlead, employee8, TaskStatus.Назначена, reports);

            Tasks task9 = new Tasks("", dateTime.AddDays(14), teamlead, employee9, TaskStatus.Назначена, reports);

            Tasks task10 = new Tasks("Бета тест", dateTime.AddMonths(3), teamlead, employee10, TaskStatus.Назначена, reports);
            
            tasks.Add(task1);
            tasks.Add(task2);
            tasks.Add(task3);
            tasks.Add(task4);
            tasks.Add(task5);
            tasks.Add(task6);
            tasks.Add(task7);
            tasks.Add(task8);
            tasks.Add(task9);
            tasks.Add(task10);

            project.status = ProjectStatus.Исполнение;

            foreach (var task in tasks)
            {
                task.status = TaskStatus.В_работе;
            }
            Reports report1 = new Reports("", task1.deadLine, teamlead);
            Reports report2 = new Reports("", task2.deadLine, employee2);
            Reports report3 = new Reports("", task3.deadLine, employee3);
            Reports report4 = new Reports("", task4.deadLine, employee4);
            Reports report5 = new Reports("", task5.deadLine, employee5);
            Reports report6 = new Reports("", task6.deadLine, employee6);
            Reports report7 = new Reports("", task7.deadLine, employee7);
            Reports report8 = new Reports("", task8.deadLine, employee8);
            Reports report9 = new Reports("", task9.deadLine, employee9);
            Reports report10 = new Reports("", task10.deadLine, employee10);


        }
    }
}