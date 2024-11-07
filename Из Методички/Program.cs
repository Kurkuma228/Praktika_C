namespace project
{
    class HomeWork
    {
        static void Main(string[] args)
        {
            /*Упражнение 2.1 Написать программу, которая спрашивает имя
            пользователя, и затем приветствует пользователя по имени. (Создать
            консольное приложение.)*/
            Console.WriteLine("Упражнение 2.1");
            Console.WriteLine("Как вас зовут?");
            Console.WriteLine("Привет" + " " + Console.ReadLine());

            /*Упражнение 2.2 Написать программу, которой на вход подается два
            целых числа, на выходе – результат деления одного числа на другое.
            Предусмотреть обработку исключительной ситуации, возникающей при
            делении числа на ноль.*/
            Console.WriteLine("Упражнение 2.2");
            int a1 = Convert.ToInt16(Console.ReadLine());
            int a2 = Convert.ToInt16(Console.ReadLine());
            if (a2 == 0)
            { Console.WriteLine("Нельзя делить на ноль"); }
            else { Console.WriteLine(a1 / a2); }

            /*Домашнее задание 2.1 Прочитать букву с экрана и вывести на печать
            следующую за ней букву в алфавитном порядке.*/
            Console.WriteLine("Домашнее задание 2.1");
            string abc = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяа";
            int num = abc.IndexOf(Console.ReadLine());
            Console.WriteLine(abc[num + 1]);

            /*Домашнее задание 2.2 Написать программу, которая решает квадратное
            уравнение. Входные данные – коэффициенты уравнения, выходные –
            найденные корни.*/
            Console.WriteLine("Домашнее задание 2.2");
            int a12 = Convert.ToInt16(Console.ReadLine());
            int b22 = Convert.ToInt16(Console.ReadLine());
            int c32 = Convert.ToInt16(Console.ReadLine());
            int dis = b22 * b22 - 4 * a12 * c32;
            if (dis >= 0)
            {
                double x1 = (-1 * b22 + Math.Sqrt(dis)) / (2 * a12);
                double x2 = (-1 * b22 - Math.Sqrt(dis)) / (2 * a12);
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else { Console.WriteLine("Нет корней"); }
        }
    }
}