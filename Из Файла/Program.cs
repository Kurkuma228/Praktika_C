using System.ComponentModel.Design.Serialization;

namespace HomeWork
{
    class File
    {
        enum Cards
        {
            Шестерка,
            Семерка,
            Восьмерка,
            Девятка,
            Десятка,
            Валет,
            Дама,
            Король,
            Туз
        }

        enum DaysWeek
        {
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Main(string[] args)
        {
            /*1. Дана последовательность из 10 чисел. Определить, является ли эта последовательность
            упорядоченной по возрастанию. В случае отрицательного ответа определить
            порядковый номер первого числа, которое нарушает данную последовательность.
            Использовать break.*/
            Console.WriteLine("1.Задание");
            Console.WriteLine("Введите десять чисел");
            try
            {
                bool increase = true;
                int past_num = int.MinValue;
                for (int i = 0; i < 10; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    increase = num > past_num;
                    if (increase == false)
                    {
                        Console.WriteLine($"Число под номером {i + 1} нарушает последовательность");
                        break;
                    }
                    past_num = num > past_num ? num : past_num;
                }
                if (increase == true)
                {
                    Console.WriteLine("Последовательнсоть возрастает");
                }
            }
            catch (FormatException ex) 
            {
                Console.WriteLine(ex.Message);
            }

            /*2. Игральным картам условно присвоены следующие порядковые номера в зависимости от
            их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
            Порядковые номера остальных карт соответствуют их названиям («шестерка»,
            «девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14) определить достоинство
            соответствующей карты. Использовать try-catch-finally.*/
            Console.WriteLine("\n2.Задание");
            Console.WriteLine("Введите номер карты. От 6 до 14");
            try
            {
                byte num_card = byte.Parse(Console.ReadLine());
                if ((6 <= num_card) && (num_card <= 14))
                {


                    switch (num_card)
                    {
                        case 6:
                            {
                                Console.WriteLine(Cards.Шестерка);
                                break;
                            }
                        case 7:
                            {
                                Console.WriteLine(Cards.Семерка);
                                break;
                            }
                        case 8:
                            {
                                Console.WriteLine(Cards.Восьмерка);
                                break;
                            }
                        case 9:
                            {
                                Console.WriteLine(Cards.Девятка);
                                break;
                            }
                        case 10:
                            {
                                Console.WriteLine(Cards.Десятка);
                                break;
                            }
                        case 11:
                            {
                                Console.WriteLine(Cards.Валет);
                                break;
                            }
                        case 12:
                            {
                                Console.WriteLine(Cards.Дама);
                                break;
                            }
                        case 13:
                            {
                                Console.WriteLine(Cards.Король);
                                break;
                            }
                        case 14:
                            {
                                Console.WriteLine(Cards.Туз);
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Число вне диапазона");
                }
            }
            
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Спасибо за ответ");
            }

            /*3. Напишите программу, которая принимает на входе строку и производит выходные
            данные в соответствии со следующей таблицей:*/
            Console.WriteLine("\n3.Задание");
            Console.WriteLine("Введите имя пьющего");
            string name = Console.ReadLine().ToLower();
            switch (name)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }

            /*4. Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,
            ...,7) выводит на экран его название (понедельник, вторник, ..., воскресенье).
            Использовать enum.*/
            Console.WriteLine("\n4.Задание");
            Console.WriteLine("Введите порядковый номер дня недели. От 1 до 7");
            try
            {
                byte num_day = byte.Parse(Console.ReadLine());
                switch (num_day - 1)
                {
                    case 0: Console.WriteLine(DaysWeek.Понедельник); break;
                    case 1: Console.WriteLine(DaysWeek.Вторник); break;
                    case 2: Console.WriteLine(DaysWeek.Среда); break;
                    case 3: Console.WriteLine(DaysWeek.Четверг); break;
                    case 4: Console.WriteLine(DaysWeek.Пятница); break;
                    case 5: Console.WriteLine(DaysWeek.Суббота); break;
                    case 6: Console.WriteLine(DaysWeek.Воскресенье); break;
                    default: Console.WriteLine("Введено неверное число"); break;
                }

            }
            catch (FormatException ex) { Console.WriteLine(ex.Message); }

            /*5. Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента
            "Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е. прибавить к
            результату. Вывести на экран сколько кукол в “сумке”.*/
            Console.WriteLine("\n5.Задание");
            string[] dolls = { "Hello Kitty", "barbie DOll" };
            int bag = 0;
            foreach (string doll in dolls)
            {
                doll.ToLower();
                if (doll == "hello kitty" || doll == "barbie doll")
                bag++;
            }
            Console.WriteLine($"Кукол в сумке {bag}");
        }
    }
}