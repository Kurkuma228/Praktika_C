using ИзМетодички.classes;

namespace metodichka
{
    class Program
    {
        static void Main(string[] args)
        {
            //Упражнения 8.1
            Console.WriteLine("Упражнения 8.1");
            Task1();
            //Упражнение 8.2
            Console.WriteLine("\nУпражнение 8.2");
            Task2();
            //Упражнение 8.3
            Console.WriteLine("\nУпражнение 8.3");
            Task3();
            //Упражнение 8.4
            Console.WriteLine("\nУпражнение 8.4");
            Task4();
            //Домашнее задание 8.1
            Console.WriteLine("\nДомашнее задание 8.1");
            Task5();
            //Домашнее задание 8.2
            Console.WriteLine("\nДомашнее задание 8.2");
            Task6();
        }

        static void Task1()
        {
            /*Упражнение 8.1 В класс банковский счет, созданный в упражнениях 7.1- 7.3 добавить
            метод, который переводит деньги с одного счета на другой. У метода два параметра: ссылка
            на объект класса банковский счет откуда снимаются деньги, второй параметр – сумма.*/

            try
            {
                BankAccount bankAcc1 = new BankAccount(0, 5000, 0);
                bankAcc1.GenAccountNumber();

                Console.WriteLine("Введите 1 для внесения денег. Введите 2 для снятия денег.\nЛюбое число или слово, кроме 1 и 2, сразу выведет на печать ваш счет");
                string check = Console.ReadLine();
                if (check == "1")
                {
                    Console.WriteLine("Введите сколько вы хотите внести");
                    decimal cash = decimal.Parse(Console.ReadLine());
                    bankAcc1.Deposit(cash);
                }
                else if (check == "2")
                {
                    Console.WriteLine("Введите сколько вы хотите снять");
                    decimal cash = decimal.Parse(Console.ReadLine());
                    bankAcc1.Withdraw(cash);
                }

                Console.WriteLine("Введите тип вашего счета: текущий или сберегательный");
                string accType = Console.ReadLine();

                if (accType.ToLower() == "сберегательный")
                {
                    bankAcc1.accountType = AccountType.Сберегательный;
                    bankAcc1.PrintAccBank();
                }
                else if (accType.ToLower() == "текущий")
                {
                    bankAcc1.accountType = AccountType.Текущий;
                    bankAcc1.PrintAccBank();
                }
                else
                {
                    Console.WriteLine("Введен неверный тип счета");
                }

                BankAccount bankAcc2 = new BankAccount(2, 1000, AccountType.Сберегательный);

                Console.WriteLine("Попытка перевода с вашего счета на другой в размере 1000 руб");
                bankAcc1.Transfer(bankAcc2, 1000);
            }
            catch (FormatException ex)
            { Console.WriteLine(ex.Message); }
            catch (OverflowException ex)
            { Console.WriteLine(ex.Message); }
        }

        static void Task2()
        {
            /*Упражнение 8.2 Реализовать метод, который в качестве входного параметра принимает
            строку string, возвращает строку типа string, буквы в которой идут в обратном порядке.
            Протестировать метод.*/

            Console.WriteLine("Введите строку");
            string stroka = Console.ReadLine();
            string newStroka = "";
            for (int i = 1; stroka.Length + 1 > i; i++)
            {
                newStroka += stroka[^i];
            }
            Console.WriteLine($"Строка в обратном порядке: {newStroka}");
        }

        static void Task3()
        {
            /*Упражнение 8.3 Написать программу, которая спрашивает у пользователя имя файла. Если
            такого файла не существует, то программа выдает пользователю сообщение и заканчивает
            работу, иначе в выходной файл записывается содержимое исходного файла, но заглавными
            буквами.*/
            try
            {
                Console.WriteLine("Введите имя файла (oldText.txt)");

                string filePath = @$"..\..\..\files\{Console.ReadLine()}";
                string oldFile = File.ReadAllText(filePath);
                string filePathNew = @"..\..\..\files\newText.txt";
                File.WriteAllText(filePathNew, oldFile.ToUpper());
                Console.WriteLine($"Содержимое выходного файла: {File.ReadAllText(filePathNew)}");
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("Файл с таким названием не найден");
            }
        }
        static void Task4()
        {
            /*Упражнение 8.4 Реализовать метод, который проверяет реализует ли входной параметр
            метода интерфейс System.IFormattable. Использовать оператор is и as. (Интерфейс
            IFormattable обеспечивает функциональные возможности форматирования значения объекта
            в строковое представление.)*/

            CheckFormat(3123);
            CheckFormat("saeaes");
        }
        static void CheckFormat(object obj)
        {
            if (obj is IFormattable)
            {
                obj = obj as IFormattable;
                Console.WriteLine($"Параметр {obj} реализует интерфейс IFormattable");
            }
            else
            {
                Console.WriteLine($"Параметр {obj} не реализует интерфейс IFormattable");
            }
        }

        static void Task5()
        {
            /*Домашнее задание 8.1 Работа со строками. Дан текстовый файл, содержащий ФИО и e-mail
            адрес. Разделителем между ФИО и адресом электронной почты является символ #:
            Иванов Иван Иванович # iviviv@mail.ru
            Петров Петр Петрович # petr@mail.ru
            Сформировать новый файл, содержащий список адресов электронной почты.
            Предусмотреть метод, выделяющий из строки адрес почты. Методу в
            качестве параметра передается символьная строка s, e-mail возвращается в той же строке s:
            public void SearchMail (ref string s).*/

            string pathNew = @"..\..\..\files\NewFile_8.1.txt";
            string pathOld = @"..\..\..\files\OldFile_8.1.txt";
            List<string> list = new List<string>();
            foreach (string line in File.ReadLines(pathNew))
            {
                list.Add(line);
            }
            string s = "";
            File.WriteAllText(pathOld, "");
            for (int i = 0; i < list.Count(); i++)
            {
                s = list[i];
                MailSep(ref s);
                File.AppendAllText(pathOld, $"{s}\n");
            }
            Console.WriteLine(File.ReadAllText(pathOld));
        }
        static void MailSep(ref string s)
        {
            int num = s.IndexOf('#');
            s = s.Substring(num + 2);
        }

        static void Task6()
        {
            /*Домашнее задание 8.2 Список песен. В методе Main создать список из четырех песен. В
            цикле вывести информацию о каждой песне. Сравнить между собой первую и вторую
            песню в списке. Песня представляет собой класс с методами для заполнения каждого из
            полей, методом вывода данных о песне на печать, методом, который сравнивает между
            собой два объекта:*/
            List<Song> list = new List<Song>();

            Song song1 = new Song();
            song1.NameSet("Last Christmas");
            song1.AuthorSet("Wham!");
            list.Add(song1);

            Song song2 = new Song();
            song2.NameSet("Last Christmas");
            song2.AuthorSet("Wham!");
            song2.PrevSet(song1);
            list.Add(song2);

            Song song3 = new Song();
            song3.NameSet("All I Want For Christmas Is You");
            song3.AuthorSet("Vince Vance & the Valiants");
            song3.PrevSet(song2);
            list.Add(song3);

            Song song4 = new Song();
            song4.NameSet("Jingle Bell Rock");
            song4.AuthorSet("Bobby Helms");
            song4.PrevSet(song3);
            list.Add(song4);

            Console.WriteLine("Список песен:");
            foreach (Song song in list)
            {
                Console.WriteLine(song.Title());
            }

            Console.WriteLine("\nСравнение первых двух песен:");
            if (song1.Equals(song2))
            {
                Console.WriteLine("Вторая песня совпадает с первой");
            }
            else
            {
                Console.WriteLine("Второая песня не совпадает с первой");
            }
        }
    }
    enum AccountType
    {
        Сберегательный,
        Текущий
    }
}