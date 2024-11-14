using System.Text.RegularExpressions;

namespace project
{
    class HomeWork
    {
        // 1 задание
        enum BankAccount
        {
            CurrentAccount,
            SavingsAccount
        }
        // 2 задание
        struct BankInfoAccount
        {
            public string number;
            public string type;
            public string balance;

            public void Print()
            { 
                Console.WriteLine($"Номер счета:{number}\nТип счета:{type}\nБаланс счета:{balance}");
            }
        }
        // 3 задание
        enum ВУЗ
        {
            КГУ,
            КАИ,
            КХТИ
        }

        struct Worker
        {
            public string name;
            public ВУЗ university;
        }
        
        static void Main(string[] args)
        {
            /*Упражнение 3.1 Создать перечислимый тип данных отображающий виды банковского
            счета(текущий и сберегательный).Создать переменную типа перечисления, присвоить ей
            значение и вывести это значение на печать.*/
            Console.WriteLine("Упражнение 3.1");
            BankAccount account_type = BankAccount.CurrentAccount;
            Console.WriteLine($"Тип счета: {account_type}");

            /*Упражнение 3.2 Создать структуру данных, которая хранит информацию
            о банковском счете – его номер, тип и баланс. Создать переменную такого типа,
            заполнить структуру значениями и напечатать результат.*/
            Console.WriteLine("Упражнение 3.2");
            BankInfoAccount bank_info = new BankInfoAccount();
            Console.WriteLine("Введите номер вашего счета:");
            bank_info.number = Console.ReadLine();
            Console.WriteLine("Введите тип вашего счета (сберегательный или текущий):");
            bank_info.type = Console.ReadLine();
            Console.WriteLine("Введите баланс вашего счета:");
            bank_info.balance = Console.ReadLine();

            if (Regex.IsMatch(bank_info.number, @"\d"))
            {
                Console.WriteLine($"Номер счета:{bank_info.number}");
            }
            else
            {
                Console.WriteLine("Номер счета введен неверно");
            }

            if ((bank_info.type.ToLower().Contains("сберегательный")) && (bank_info.type.ToLower().Contains("текущий")))
            {
                Console.WriteLine($"Тип счета может быть только один");
            }
            else if ((bank_info.type.ToLower().Contains("сберегательный")))
            {
                Console.WriteLine($"Тип счета: Сберегательный");
            }
            else if ((bank_info.type.ToLower().Contains("текущий"))) // проблемка
            {
                Console.WriteLine($"Тип счета: Текущий");
            }
            else
            {
                Console.WriteLine("Тип счета введен неверно");
            }

            if (Regex.IsMatch(bank_info.balance, @"\d"))
            {
                Console.WriteLine($"Баланс счета:{bank_info.balance}");
            }
            else
            {
                Console.WriteLine("Баланс введен неверно");
            }

            /*Домашнее задание 3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать
            структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и
            распечатать.*/
            Console.WriteLine("Домашнее задание 3.1");
            Worker worker = new Worker();

            Console.WriteLine("Введите имя работника");
            worker.name = Console.ReadLine();

            Console.WriteLine("Введите ВУЗ работника");
            bool vuz = true;

            switch (Console.ReadLine())
            {
                case "КГУ":
                    worker.university = ВУЗ.КГУ;
                    break;
                case "КАИ":
                    worker.university = ВУЗ.КАИ;
                    break;
                case "КХТИ":
                    worker.university = ВУЗ.КХТИ;
                    break;
                default:
                    vuz = false;
                    break;
            }
            if (vuz)
            {
                Console.WriteLine($"Имя работника:{worker.name} \nВУЗ работника:{worker.university}");
            }
            else
            {
                Console.WriteLine("ВУЗ введен неверно или же их нет в списке");
            }
        }
    }
}