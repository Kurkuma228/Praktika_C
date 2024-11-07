using System;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace project
{
    class HomeWork
    {
        static void Main(string[] args)
        {
            //1. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
            Console.WriteLine("1.Задание");
            Console.WriteLine("e = 2,7");

            //2. Вывести на экран числа 50 и 10 одно под другим.
            Console.WriteLine("2.Задание");
            Console.WriteLine(50);
            Console.WriteLine(10);

            //3. Составить программу вывода на экран «столбиком» четырех любых чисел.
            Console.WriteLine("3.Задание");
            Console.WriteLine(10);
            Console.WriteLine(20);
            Console.WriteLine(30);
            Console.WriteLine(40);

            //4. Пользователь вводит число. Выведите на экран число, которое больше введенного на 10.
            Console.WriteLine("4.Задание");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + 10);

            //5. Дана сторона квадрата. Найти его периметр.
            Console.WriteLine("5.Задание");
            int len1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"P = {len1 * 4}");

            //6. Дан радиус окружности. Найти длину окружности и площадь круга.
            Console.WriteLine("6.Задание");
            int rad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"l = {rad * Math.PI* 2}");
            Console.WriteLine($"s = {rad * rad * Math.PI}");

            //7. Найти значение y=cos(x)
            Console.WriteLine("7.Задание");
            Console.WriteLine("Введите значение в градусах");
            double grad = Convert.ToDouble(Console.ReadLine());
            double radian = Math.Cos(grad *(Math.PI / 180));
            Console.WriteLine($"y = {radian}");

            //8. Даны основания и высота равнобедренной трапеции. Найти ее периметр.
            Console.WriteLine("8.Задание");
            int basa1 = Convert.ToInt32(Console.ReadLine());
            int basa2 = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            double side1 = Math.Sqrt(height * height + Math.Pow((Math.Abs(basa1 - basa2) / 2), 2));
            Console.WriteLine($"P = {basa1 + basa2 + side1 * 2}");

            //9. Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки,
            //если купили x кг конфет, у кг печенья и z кг яблок.
            Console.WriteLine("9.Задание");
            Console.WriteLine("Ввести три цены и купленное количество");
            int sweet_price = Convert.ToInt32(Console.ReadLine());
            int cookie_price = Convert.ToInt32(Console.ReadLine());
            int apple_price = Convert.ToInt32(Console.ReadLine());
            int x_sweet = Convert.ToInt32(Console.ReadLine());
            int y_cookie = Convert.ToInt32(Console.ReadLine());
            int z_apple = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sweet_price * x_sweet + cookie_price * y_cookie + apple_price * z_apple);

            /*10. Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май"
            (кавычки не нужны). Причём сделайте, чтобы выводилось сначала так:
            Мир Труд Май
            Затем так:
            Мир
                 Труд
                       Май
            */
            Console.WriteLine("10.Задание");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("     Труд");
            Console.WriteLine("           Май");

            /*11. Программа просит пользователя ввести 2 числовые переменные. А после она
            меняет их местами и выводит результат на экран. Но, так как пользователь может
            ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести,
            например, букву или строку, а так же учесть, что число может быть дробным, и для
            выделения её дробной части одни используют точку, другие – запятую.*/
            Console.WriteLine("11.Задание");
            try
            {
                Console.WriteLine("Ведите 2 числовые переменные");
                string a11 = Console.ReadLine().Replace(".", ",");
                string b11 = Console.ReadLine().Replace(".", ",");
                double new_a11 = Convert.ToDouble(a11);
                double new_b11 = Convert.ToDouble(b11);
                (new_a11, new_b11) = (new_b11, new_a11);
                Console.WriteLine(new_a11+ " " + new_b11);

            }
            catch
            {
                Console.WriteLine("Неверный ввод");
            }
            /*12. Программа для подсчета периметра и площади фигур (треугольник,
            четырехугольник, круг). Пользователь выбирает фигуру, указывает, что программа
            будет считать – площадь или периметр. Задаётся все необходимые значения, а на
            основе полученных результатов, программа должна подсчитать, какими могли бы
            быть периметры или площади остальных фигур.*/
            //S = √p · (p — a)(p — b)(p — c)
            Console.WriteLine("12.Задание");
            Console.WriteLine("Введите нужную фигуру: треугольник, четырехугольник, круг.");
            string figure12 = Console.ReadLine();

            if (figure12 == "треугольник" || figure12 == "Треугольник")
            {
                try
                {
                    Console.WriteLine("Введите, что будет считать программа - площадь или периметр");
                    string formula12 = Console.ReadLine();
                    Console.WriteLine("Введите три стороны треугольника");              //стороны
                    double tria1 = Convert.ToDouble(Console.ReadLine());
                    double tria2 = Convert.ToDouble(Console.ReadLine());
                    double tria3 = Convert.ToDouble(Console.ReadLine());
                    if (formula12 == "площадь")                                         //площадь
                    {
                        double p12 = tria1 + tria2 + tria3;
                        double sq12 = Math.Sqrt(p12 * (p12 - tria1) * (p12 - tria2) * (p12 - tria3));
                        Console.WriteLine($"Ответ: {sq12}");
                    }
                    if (formula12 == "периметр")                                        //периметр
                    {
                        Console.WriteLine($"Ответ: {tria1 + tria2 + tria3}");
                    }
                }
                catch { Console.WriteLine("Неверный Ввод"); }
            }

            if (figure12 == "круг" || figure12 == "Круг")
            {
                try
                {
                    Console.WriteLine("Введите, что будет считать программа - площадь или периметр");
                    string formula12 = Console.ReadLine();
                    Console.WriteLine("Введите радиус круга");
                    double rad12 = Convert.ToDouble(Console.ReadLine());
                    if (formula12 == "площадь")
                    {
                        double p12 = rad12 * Math.PI * 2;
                        double sq12 = Math.Pow(rad12, 2) * Math.PI;
                        Console.WriteLine($"Ответ: {sq12}");
                    }
                    if (formula12 == "периметр")
                    {
                        Console.WriteLine($"Ответ: {rad12 * Math.PI * 2}");
                    }
                }
                catch { Console.WriteLine("Неверный Ввод"); }
            }

            if (figure12 == "четырехугольник" || figure12 == "Четырехугольник")
            {
                try
                {
                    Console.WriteLine("Введите, что будет считать программа - площадь или периметр");
                    string formula12 = Console.ReadLine();
                    if (formula12 == "площадь")
                    {
                        Console.WriteLine("Введите основание и высоту падающую на это основание четырехугольника");
                        double base12 = Convert.ToDouble(Console.ReadLine());
                        double height12 = Convert.ToDouble(Console.ReadLine());
                        double sq12 = base12 * height12;
                        Console.WriteLine($"Ответ: {sq12}");
                    }
                    if (formula12 == "периметр")
                    {
                        Console.WriteLine("Введите величины четырех сторон четырехугольника");
                        double side112 = Convert.ToDouble(Console.ReadLine());
                        double side212 = Convert.ToDouble(Console.ReadLine());
                        double side312 = Convert.ToDouble(Console.ReadLine());
                        double side412 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Ответ: {side112 + side212 + side312 + side412}");
                    }
                }
                catch { Console.WriteLine("Неверный Ввод"); }
            }
            else
            {
                Console.WriteLine("Неверный Ввод");
            }

            //13. Составить программу вывода на экран числа, вводимого с клавиатуры. Вводимому
            //числу должно предшествовать сообщение «Вы ввели число».
            Console.WriteLine("13.Задание");
            try
            {
                double a13 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Вы ввели число {a13}");
            }
            catch { Console.WriteLine("Неверный ввод"); }

            //14. Составить программу вывода на экран следующей информации:
            //2 кг
            //13 17
            Console.WriteLine("14.Задание");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");

            //15. Составить программу вывода на экран «столбиком» четырех случайных чисел.
            Console.WriteLine("15.Задание");
            for (int b = 0; b < 4; b++)
            {
                Random rnd1 = new Random();

                int a = rnd1.Next(10000);
                Console.WriteLine(a);
            }

            //16. Найти корни квадратного уравнения(коэффициента задаются пользователем с
            //клавиатуры)
            Console.WriteLine("16.Задание");
            Console.WriteLine("Введите коэффиценты");
            double a16 = Convert.ToDouble(Console.ReadLine());
            double b16 = Convert.ToDouble(Console.ReadLine());
            double c16 = Convert.ToDouble(Console.ReadLine());
            double dsk16 = b16 * b16 - 4 * a16 * c16;
            if (dsk16 > 0)
            {
                double answer161 = (-1 * b16 + Math.Sqrt(dsk16)) / (2 * a16);
                double answer162 = (-1 * b16 - Math.Sqrt(dsk16)) / (2 * a16);
                Console.WriteLine($"x1 = answer161, x2 = {answer162}");
            }
            if (dsk16 == 0)
            { Console.WriteLine($"x = {(-1 * b16 + Math.Sqrt(dsk16)) / (2 * a16)}"); }
            else { Console.WriteLine("Нет решений"); }

            //17. Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее
            //геометрическое.
            Console.WriteLine("17.Задание");
            int num117 = Convert.ToInt32(Console.ReadLine());
            int num217 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"a) {(num117 + num217) / 2}");
            Console.WriteLine($"б) {Math.Sqrt(num117 * num217)}");

            //18. Известны координаты на плоскости двух точек. Составить программу вычисления
            //расстояния между ними.
            Console.WriteLine("18.Задание");
            int crx118 = Convert.ToInt32(Console.ReadLine());
            int cry118 = Convert.ToInt32(Console.ReadLine());
            int crx218 = Convert.ToInt32(Console.ReadLine());
            int cry218 = Convert.ToInt32(Console.ReadLine());

            double answer18 = Math.Sqrt(Math.Pow(Math.Abs(crx218 - crx118), 2) + Math.Pow(Math.Abs(cry218 - cry118), 2));
            Console.WriteLine(answer18);

            //19. Составить программу обмена значениями трех переменных величин а, b, c по
            //следующим двум схемам:
            //а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
            //б) b присвоить значение а, с присвоить значение b, а присвоить значение с.
            Console.WriteLine("19.Задание");
            Console.WriteLine("Введите три значения");
            int a19 = Convert.ToInt32(Console.ReadLine());
            int b19 = Convert.ToInt32(Console.ReadLine());
            int c19 = Convert.ToInt32(Console.ReadLine());
            (int a219, int b219, int c219) = (b19, c19, a19);
            Console.WriteLine($"а){a219}, {b219}, {c219}");
            (int a319, int b319, int c319) = (c19, a19, b19);
            Console.WriteLine($"а){a319}, {b319}, {c319}");

            /*20. С начала суток прошло n секунд. Определить:
            а) сколько полных часов прошло с начала суток;
            б) сколько полных минут прошло с начала очередного часа;
            в) сколько полных секунд прошло с начала очередной минуты.*/
            Console.WriteLine("20.Задание");
            double n20 = Convert.ToDouble(Console.ReadLine());
            double hour20 = Math.Round(n20 / 60 / 60 % 24, MidpointRounding.ToNegativeInfinity);
            Console.WriteLine(hour20);
            double min20 = Math.Round(n20 / 60 % 60, MidpointRounding.ToNegativeInfinity);
            Console.WriteLine(min20);
            double sec20 = Math.Round(n20 % 60, MidpointRounding.ToNegativeInfinity);
            Console.WriteLine(sec20);

            //21. Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130
            //мм можно отрезать от него ?
            Console.WriteLine("21.Задание");
            double rectangle = 543 * 130;
            Console.WriteLine($"Ответ:{Math.Round(rectangle / 130 * 130, MidpointRounding.ToNegativeInfinity)}");

            //22. Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали
            //ее в начале.Найти полученное число.
            Console.WriteLine("22.Задание");
            int num122 = Convert.ToInt32(Console.ReadLine());
            string num222 = Convert.ToString(num122 % 10);
            Console.WriteLine(num222 + Convert.ToString(num122 / 10));

            //23. Дано натуральное число n (n > 999). Найти:
            //а) число сотен в нем;
            //б) число тысяч в нем.
            Console.WriteLine("23.Задание");
            int n23 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n23 / 100);
            Console.WriteLine(n23/ 1000);

            /*24. Дано четырехзначное число. Найти:
            а) число, полученное при прочтении его цифр справа налево;
            б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр
            заданного числа. Например, из числа 5434 получить 4543, из числа 7048 — 784;
            в) число, образуемое при перестановке второй и третьей цифр заданного числа.
            Например, из числа 5084 получить 5804;
            г) число, образуемое при перестановке двух первых и двух последних цифр
            заданного числа. Например, из числа 4566 получить 6645, из числа 7304 — 473.*/
            Console.WriteLine("24.Задание");
            int n24 = Convert.ToInt32(Console.ReadLine());
            (string a24, string b24, string c24, string d24) = (Convert.ToString(n24 / 1000), Convert.ToString(n24 / 100 % 10), Convert.ToString(n24 / 10 % 10),
                Convert.ToString(n24 % 10));
            Console.WriteLine(Convert.ToInt16(d24 + c24 + b24 + a24));
            Console.WriteLine(Convert.ToInt16(b24 + a24 + d24 + c24));
            Console.WriteLine(Convert.ToInt16(a24 + c24 + b24 + d24));
            Console.WriteLine(Convert.ToInt16(c24 + d24 + a24 + b24));

            /*25. Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили
            на 10, а к частному слева приписали последнюю цифру числа x, то получилось
            число n. Найти число x. Значение n вводится с клавиатуры, 100 ≤ n ≤ 999 и при этом
            число десятков в n не равно нулю.*/
            Console.WriteLine("25.Задание");
            int n25 = Convert.ToInt32(Console.ReadLine());
            string answer25 = Convert.ToString(n25 % 100) + Convert.ToString(n25 / 100);
            Console.WriteLine(answer25);

            /*26. Даны целые числа h, m, s (0 ≤ h ≤ 23, 0 ≤ m ≤ 59, 0 ≤ s ≤ 59), указывающие момент
            времени: «h часов, m минут, s секунд». Определить угол (в градусах) между
            положением часовой стрелки в начале суток и в указанный момент времени.*/
            Console.WriteLine("26.Задание");
            int h26 = Convert.ToInt32(Console.ReadLine());
            int m26 = Convert.ToInt32(Console.ReadLine());
            int s26 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((h26 * 30 + m26 * 0.5 + s26 * (1 / 120)) % 180);

            /*27. Часовая стрелка образует угол y с лучом, проходящим через центр и через точку,
            соответствующую 12 часам на циферблате, 0 ≤ y ≤ 2 . Определить значение угла для
            минутной стрелки, а также количество полных часов и полных минут.*/
            Console.WriteLine("27.Задание");
            double y27 = Convert.ToDouble(Console.ReadLine());
            double angle27 = y27 * 180;                                         //Предполагается, что угол в радианах без Пи
            Console.WriteLine($"Угол мин стрелки {(angle27 % 30 * 2) * 6}");    //1 час это 30 градусов, 2 мин это 1 градус (на часовой стрелке),
            Console.WriteLine($"Полные часы:{Convert.ToInt16(angle27 / 30)}");  //1 мин от полного круга 6 градусов (минутная стрелка)
            Console.WriteLine($"Полные минуты:{Convert.ToInt16(angle27 % 30 * 2)}");

            /*28. Создать программу, которая будет выводить на экран меньшее по модулю из трёх
            введённых пользователем вещественных чисел*/
            Console.WriteLine("28.Задание");
            double a128 = Convert.ToDouble(Console.ReadLine());
            double b128 = Convert.ToDouble(Console.ReadLine());
            double c128 = Convert.ToDouble(Console.ReadLine());
            double a28 = Math.Abs(a128);
            double b28 = Math.Abs(b128);
            double c28 = Math.Abs(c128);

            if (a28 <= b28 && a28 <= c28)
            { Console.WriteLine(a128); }
            if (b28 <= c28 && b28 <= a28)
            {  Console.WriteLine(b128); }
            if (c28 <= a28 && c28 <= b28)
            { Console.WriteLine(c128); }

            //29. Найти сумму большего и меньшего из трёх заданных чисел
            Console.WriteLine("29.Задание");
            double a29 = Convert.ToDouble(Console.ReadLine());
            double b29 = Convert.ToDouble(Console.ReadLine());
            double c29 = Convert.ToDouble(Console.ReadLine());

            double min29 = 0;
            double max29 = 0;
            if (a29 <= b29 && a29 <= c29)
            { min29 = a29; }
            if (b29 <= c29 && b29 <= a29)
            { min29 = b29; }
            if (c29 <= a29 && c29 <= b29)
            { min29 = c29; }

            if (a29 >= b29 && a29 >= c29)
            { max29 = a29; }
            if (b29 >= c29 && b29 >= a29)
            { max29 = b29; }
            if (c29 >= a29 && c29 >= b29)
            { max29 = c29; }
            Console.WriteLine(min29 + max29);

            //30. Подсчитать общее количество делителей натурального числа
            Console.WriteLine("30.Задание");
            int n30 = Convert.ToInt32(Console.ReadLine());
            int res30 = 0;
            for (int i = 1; i <= n30; ++i)
            {
                if (n30 % i == 0)
                { ++res30; }
            }
            Console.WriteLine(res30);

            /*31. Вася в школе изучил квадратные уравнения и понял, как они легко решаются путем
            вычисления дискриминанта. Но Петя поведал ему о методе решения кубических
            уравнений вида A*X3 + B*X2 + C*X + D = 0. На факультативе по математике Васе
            задали решить около ста уравнений как раз такого вида. Но, к сожалению, Вася
            забыл формулы, о которых рассказывал ему Петя. Но Васе было известно, что все
            корни уравнений – целые числа и находятся на отрезке [-100, 100]. Поэтому у Васи
            есть шанс найти их методом перебора, но для этого ему придется затратить уйму
            времени, т.к. возможно необходимо будет осуществить перебор нескольких тысяч
            значений. Помогите Васе написать программу, которая поможет ему найти корни
            кубических уравнений!*/
            Console.WriteLine("31.Задание");
            Console.WriteLine("Задайте коэффициенты");
            int a31 = Convert.ToInt32(Console.ReadLine());
            int b31 = Convert.ToInt32(Console.ReadLine());
            int c31 = Convert.ToInt32(Console.ReadLine());
            int d31 = Convert.ToInt32(Console.ReadLine());
            for (int x1 = -100; x1 <= 100; ++x1)
            {
                if ((a31 * (x1 * x1 * x1) + b31 * (x1 * x1) + c31 * x1 + d31) == 0)
                { Console.WriteLine($"x = {x1}"); }
            }

            /*32. Заданы первый и второй элементы арифметической прогрессии. Требуется
            написать программу, которая вычислит элемент прогрессии по ее номеру.*/
            Console.WriteLine("32.Задание");
            int num132 = Convert.ToInt32(Console.ReadLine());  
            int num232 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер искомого элемента прогрессии");
            int n32 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num132 + (num232 - num132) * (n32 - 1));

            /*33. Если я пенсионер или студент и не трудоустроен, то получаю кредит, а если
            трудоустроен не получаю кредит. Ну а если я, и пенсионер и
            студент,(трудоустройство тут не имеет значения) то не должен получить.
            Необходимо вводить строки, содержащие информацию о том, студент, пенсионер
            или кто-то ещё. Вывести информацию: дадут кредит или нет.*/
            Console.WriteLine("33.Задание");
            string text33 = Console.ReadLine();


            /*34. Составить программу, которая:
            а) запрашивает имя человека и повторяет его на экране;

            б) запрашивает имя человека и повторяет его на экране с приветствием.*/
            Console.WriteLine("34.Задание");
            Console.WriteLine("Напишите свое имя");
            Console.WriteLine("a)" + Console.ReadLine());
            Console.WriteLine("Напишите свое имя");
            Console.WriteLine("б)" + "Привет" + Console.ReadLine());

            /*35. Воспроизвести разговор Гарри и дневника Тома Реддла. Пользователь здоровается с
            консолью. Консоль спрашивает, как зовут пользователя. Пользователь называет
            имя. Консоль пишет: привет, <имя пользователя>. После этого пользователь
            спрашивает, знает ли консоль что-то о тайной комнате. Консоль отвечает «Да».
            После этого пользователь спрашивает, может ли рассказать. Консоль отвечает
            «Нет». Спустя 5 секунд консоль дополняет «но могу показать». Консоль меняет
            цвет на любой случайный цвет.*/
            Console.WriteLine("35.Задание");
            Console.ReadLine();
            Console.WriteLine("Как вас зовут?");
            string a35 = Console.ReadLine();
            Console.WriteLine("Привет, a35");
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine();
            Console.WriteLine("Нет");
            Task.Delay(500);
            Random rnd2 = new Random();
            int rando = rnd2.Next(3);
            if (rando == 1)
            { Console.ForegroundColor = ConsoleColor.Red; }
            if (rando == 2)
            {  Console.ForegroundColor = ConsoleColor.Blue;}
            if (rando == 3)
            {  Console.ForegroundColor = ConsoleColor.Green;}

            /*36. Вычислить контрольную цифру штрихкода(EAN13).
            a. 12 цифр определяются случайным образом.
            b. 12 цифр вводит пользователь*/
            Console.WriteLine("36.Задание");
            Random rnd3 = new Random();
            int a36 = 100000;
            int b36 = 999999;
            string rando3 = Convert.ToString(rnd3.Next(a36, b36));
            string rando4 = Convert.ToString(rnd3.Next(b36, a36));
            int sum36 = 0;
            string EAN13 = rando3 + rando4;
            for (int i = 0; i < 6; i += 2)
            {
                int c36 = Convert.ToInt32(EAN13[i]);
                sum36 += c36;
                    }
            sum36 *= 3;
            for (int i = 0; i < 5; i++)
            { sum36 += Convert.ToInt16(EAN13[i + 1]); }
            sum36 = sum36 % 10;
            if (sum36 == 0)
            { Console.WriteLine(sum36); }
            else { Console.WriteLine(10 - sum36); }
            Console.WriteLine("Введите 12 цифр");
            string EAN = Console.ReadLine();
            for (int i = 0; i < 6; i += 2)
            {
                int c36 = Convert.ToInt32(EAN[i]);
                sum36 += c36;
            }
            sum36 *= 3;
            for (int i = 0; i < 5; i++)
            { sum36 += Convert.ToInt16(EAN[i + 1]); }
            sum36 = sum36 % 10;
            if (sum36 == 0)
            { Console.WriteLine(sum36); }
            else { Console.WriteLine(10 - sum36); }
        }
    }
}

