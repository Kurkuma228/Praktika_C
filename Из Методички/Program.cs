using ИзМетодички.classes;

namespace metodichka
{
    class Program
    {
        static void Main(string[] args)
        {
            //Упражнения 9.1 - 9.3
            Console.WriteLine("Упражнения 9.1");
            Task1();
            //Домашнее задание 9.1
            Console.WriteLine("\nДомашнее задание 9.1");
            Task2();
            
        }

        static void Task1()
        {
            /*Упражнение 9.1 В классе банковский счет, созданном в предыдущих упражнениях, удалить
            методы заполнения полей. Вместо этих методов создать конструкторы. Переопределить
            конструктор по умолчанию, создать конструктор для заполнения поля баланс, конструктор
            для заполнения поля тип банковского счета, конструктор для заполнения баланса и типа
            банковского счета. Каждый конструктор должен вызывать метод, генерирующий номер
            счета.*/

            try
            {
                BankAccount bankAcc1 = new BankAccount(5000, AccountType.Сберегательный);

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

                BankAccount bankAcc2 = new BankAccount(10000, AccountType.Сберегательный);

                Console.WriteLine("Попытка перевода с вашего счета на другой в размере 1000 руб");
                bankAcc1.Transfer(bankAcc2, 1000);
                bankAcc1.Dispose();
                Console.WriteLine("Проводки в файле:");
                bankAcc1.PrintFileQueue();
            }
            catch (FormatException ex)
            { Console.WriteLine(ex.Message); }
            catch (OverflowException ex)
            { Console.WriteLine(ex.Message); }
        }
        static void Task2()
        {
            /*Домашнее задание 9.1 В класс Song (из домашнего задания 8.2) добавить следующие
            конструкторы:
            1) параметры конструктора – название и автор песни, указатель на предыдущую песню
            инициализировать null.
            2) параметры конструктора – название, автор песни, предыдущая песня. В методе Main
            создать объект mySong. Возникнет ли ошибка при инициализации объекта mySong
            следующим образом: Song mySong = new Song(); ?
            Исправьте ошибку, создав необходимый конструктор.*/
            List<Song> list = new List<Song>();

            Song song1 = new Song("Last Christmas", "Wham!");
            list.Add(song1);

            Song song2 = new Song("Last Christmas", "Wham!", song1);
            list.Add(song2);

            Song song3 = new Song("All I Want For Christmas Is You", "Vince Vance & the Valiants", song2);
            list.Add(song3);

            Song song4 = new Song("Jingle Bell Rock", "Bobby Helms", song3);
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
}