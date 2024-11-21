using System.Text.RegularExpressions;

namespace project
{
    class HomeWork
    {
        static void Main(string[] args)
        {
            /*Упражнение 4.1 Написать программу, которая читает с экрана число от 1 до 365 (номер дня
            в году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9
            февраля (високосный год не учитывать).*/
            Console.WriteLine("Упражнение 4.1");
            Console.WriteLine("Введите день года. От 1 до 365");
            try
            {
                short numday = short.Parse(Console.ReadLine());
                if (numday <= 365 && numday >= 1)
                {
                    DateOnly days = DateOnly.FromDayNumber(numday);
                    Console.WriteLine($"{days:m}");
                }
                else
                {
                    Console.WriteLine("Число выходит за границы");
                }
            }
            catch (FormatException ex)
            { 
                Console.WriteLine(ex.Message);
            }

            /*Упражнение 4.2 Добавить к задаче из предыдущего упражнения проверку числа введенного
            пользователем. Если число меньше 1 или больше 365, программа должна вырабатывать
            исключение, и выдавать на экран сообщение.*/
            Console.WriteLine("\nУпражнение 4.2");
            Console.WriteLine("Введите день года. От 1 до 365");
            try
            {
                short numday = short.Parse(Console.ReadLine());
                if (numday <= 365 && numday >= 1)
                {
                    DateOnly days = DateOnly.FromDayNumber(numday);
                    Console.WriteLine($"{days:m}");
                }
                else
                {
                    Console.WriteLine("Число выходит за границы");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            /*Домашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она
            учитывала год (високосный или нет). Год вводится с экрана. (Год високосный, если он
            делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный
            год. Однако, если он делится без остатка на 400, это високосный год.)*/
            Console.WriteLine("\nДомашнее задание 4.1");
            try
            {
                Console.WriteLine("Введите день года. От 1 до 365");
                short numday = short.Parse(Console.ReadLine());
                Console.WriteLine("Введите год");
                ushort numyear = ushort.Parse(Console.ReadLine());
                if (numday <= 365 && numday >= 1)
                {
                    DateOnly days = DateOnly.FromDayNumber(numday);
                    if ((numyear % 4 == 0 &&  numyear % 100 != 0) || (numyear % 400 == 0))
                    {
                        Console.WriteLine($"{days:m}, {numyear} год високосный");
                    }
                    else
                    {
                        Console.WriteLine($"{days:m}, {numyear} год не високосный");
                    }
                }
                else
                {
                    Console.WriteLine("Число выходит за границы");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"{ex.Message} \nВозможно вы ввели отрицательный год");
            }
        }
    }
}
