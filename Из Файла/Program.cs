using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Security.Principal;
using System.Text.RegularExpressions;

namespace project
{
    class HomeWork
    {
        
        static void Main(string[] args)
        {
            /*1. Выведите на экран информацию о каждом типе данных в виде:
            Тип данных – максимальное значение – минимальное значение*/
            Console.WriteLine("Задание 1");
            Console.WriteLine("1.Логический тип");
            Console.WriteLine("bool = два значение true and false\n");
            Console.WriteLine("2.Целочисленный тип");
            Console.WriteLine("byte = max 255, min 0 \nsbyte = max 127, min -128\n");
            Console.WriteLine("short = max 32767, min -32768 \nushort = max 65535, min 0\n");
            Console.WriteLine("int = max 2147483647, min -2147483648 \nuint = max 4294967295, min 0\n");
            Console.WriteLine("long = max 9 223 372 036 854 775 807, min = –9 223 372 036 854 775 808 \nulong = max 18 446 744 073 709 551 615, min 0\n");
            Console.WriteLine("3.Вещественный тип");
            Console.WriteLine("float = max 3.402823e38, min -3.402823\n");
            Console.WriteLine("double = max 1.797693e308, min -1.797693e308\n");
            Console.WriteLine("decimal = max 7.922816e28, min -7.922816e28\n");
            Console.WriteLine("4.Строковые типы данных");
            Console.WriteLine("char = Одиночный символ в кодировке юникод, 2 байта\n");
            Console.WriteLine("string = Около двух миллиардов символов, 10 байтов\n");
            Console.WriteLine("5.Object");
            Console.WriteLine("Object = 4 байта\n");

            /*2. Напишите программу, в которой принимаются данные пользователя в виде имени,
            города, возраста и PIN-кода. Далее сохраните все значение в соответствующей
            переменной, а затем распечатайте всю информацию в правильном формате.*/
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ваш город");
            string city = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст (в виде числа)");
            string age = Console.ReadLine();
            Console.WriteLine("Введите ваш пин-код");
            string pincode = Console.ReadLine();
            if (Regex.IsMatch(age, @"\d") && Regex.IsMatch(pincode, @"\d"))
            {
                Console.WriteLine($"Имя: {name}\nГород: {city}\nВозраст: {age}\nПин-Код: {pincode}\n");
            }
            else
            {
                Console.WriteLine("Пин-код или возраст введены неверно\n");
            }

            /*3. Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на
            строчные.*/
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            string new_str = "";
            foreach (var s in str)
            {
                if ((string.Compare(Convert.ToString(s), Convert.ToString(s).ToLower())) == 0)
                {
                    new_str += Convert.ToString(s).ToUpper();
                }
                else
                {
                    new_str += Convert.ToString(s).ToLower();
                }
            }
            Console.WriteLine($"{new_str}\n");

            /*4. Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести
            на экран.*/
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите строку");
            string stroka = Console.ReadLine();
            Console.WriteLine("Введите подстроку");
            string podstroka = Console.ReadLine();
            int res = 0;
            while (stroka.Length > 0)
            {

                int index = stroka.LastIndexOf(podstroka);
                if (index == -1)
                {
                    break;
                }
                stroka = stroka.Substring(0, index);
                res++;
            }
            Console.WriteLine($"Количество вхождений: {res}");

            /*5. Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам
            нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически
            покрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена (normPrice),
            скидка в Duty Free (salePrice) и стоимость отпуска (holidayPrice). Например, если бутылка
            обычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10%, вы
            сэкономите 1 фунт стерлингов на каждой бутылке. Если ваш отпуск стоит 500 фунтов
            стерлингов, ответ, который вы должны вернуть, будет 500. Все входные данные будут
            целыми числами. Пожалуйста, верните целое число. Округлить в меньшую сторону.*/
            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите цену бутылки");
            int normprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите скидку");
            int saleprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цену отпуска");
            int holidayprice = Convert.ToInt32(Console.ReadLine());
            double profit = normprice * saleprice / 100;
            double amountbottles = holidayprice / profit;
            Console.WriteLine($"Количество бутылок: {Math.Floor(amountbottles)}");

            /*6. Создать структуру студента. У студента есть Фамилия, Имя, его Идентификатор, Дата
            рождения, Категория алкоголизма (a – студент алкоголик, b – студент любитель
            выпить, но не алкоголик, c – студент пьет по праздникам, d – студент не пьет), также у
            студента есть Объем выпитой жидкости конкретного напитка. Создать 5 студентов с
            различными параметрами. Посчитать общий объем выпитого, общий объем алкоголя
            (процент спирта) и кто сколько процентов алкоголя и жидкости от общего количества
            выпил. Предполагается, что студент пьет один вид напитка. Напитки задать в виде
            структуры: наименование типа напитка и процент спирта.*/

            Console.WriteLine("Задание 6");

            Alco_drink wine = new Alco_drink("Вино", 13);
            Alco_drink beer = new Alco_drink("Пиво", 3);
            Alco_drink vodka = new Alco_drink("Водка", 40);
            Alco_drink cola = new Alco_drink("Кола", 0);
            Alco_drink absinthe = new Alco_drink("Абсент", 60);

            Student_info student1 = new Student_info("Василий", "Пупкин", 1, new DateTime(2000, 04, 12), "a", absinthe, 0.3);
            Student_info student2 = new Student_info("Мария", "Васильева", 2, new DateTime(2001, 12, 11), "b", vodka, 0.5);
            Student_info student3 = new Student_info("Алексей", "Иванов", 3, new DateTime(2000, 12, 28), "c", wine, 0.7);
            Student_info student4 = new Student_info("Петр", "Федоров", 9, new DateTime(2001, 09, 07), "d", cola, 2);
            Student_info student5 = new Student_info("Елена", "Веселая", 7, new DateTime(2002, 07, 06), "c", beer, 1.5);
            // Объем в литрах
            double volume_general = student1.Volume + student2.Volume + student3.Volume + student4.Volume + student5.Volume;
            double volume_alcohol = (absinthe.alco_Percent * student1.Volume) + (vodka.alco_Percent * student2.Volume) + (wine.alco_Percent * student3.Volume)
                + (cola.alco_Percent * student4.Volume) + (beer.alco_Percent * student5.Volume);

            Console.WriteLine($"Общий объем выпитого:{volume_general} \nОбщий объем алкоголя:{volume_alcohol}\n");

            Console.WriteLine($"Студент: {student1.Firstname} {student1.Lastname}");
            Console.WriteLine($"Идентификатор: {student1.Id}, Дата рождения: {student1.Birthday}");
            Console.WriteLine($"Категория алкоголизма: {student1.Category_alcoholic}");
            Console.WriteLine($"Объем выпитого: {student1.Volume} литров");
            Console.WriteLine($"Напиток: {student1.alco_Drink.name_Drink}, Процент алкоголя: {student1.alco_Drink.alco_Percent}%");
            Console.WriteLine($"Объем алкоголя от общего: {(absinthe.alco_Percent * student1.Volume) / volume_alcohol * 100}%");
            Console.WriteLine($"Объем жидкости от общего: {student1.Volume / volume_general * 100}%");
            Console.WriteLine();

            Console.WriteLine($"Студент: {student2.Firstname} {student2.Lastname}");
            Console.WriteLine($"Идентификатор: {student2.Id}, Дата рождения: {student2.Birthday}");
            Console.WriteLine($"Категория алкоголизма: {student2.Category_alcoholic}");
            Console.WriteLine($"Объем выпитого: {student2.Volume} литров");
            Console.WriteLine($"Напиток: {student2.alco_Drink.name_Drink}, Процент алкоголя: {student2.alco_Drink.alco_Percent}%");
            Console.WriteLine($"Объем алкоголя от общего: {(vodka.alco_Percent * student2.Volume) / volume_alcohol * 100}%");
            Console.WriteLine($"Объем жидкости от общего: {student2.Volume / volume_general * 100}%");
            Console.WriteLine();

            Console.WriteLine($"Студент: {student3.Firstname} {student3.Lastname}");
            Console.WriteLine($"Идентификатор: {student3.Id}, Дата рождения: {student3.Birthday}");
            Console.WriteLine($"Категория алкоголизма: {student3.Category_alcoholic}");
            Console.WriteLine($"Объем выпитого: {student3.Volume} литров");
            Console.WriteLine($"Напиток: {student3.alco_Drink.name_Drink}, Процент алкоголя: {student3.alco_Drink.alco_Percent}%");
            Console.WriteLine($"Объем алкоголя от общего: {(wine.alco_Percent * student3.Volume) / volume_alcohol * 100}%");
            Console.WriteLine($"Объем жидкости от общего: {student3.Volume / volume_general * 100}%");
            Console.WriteLine();

            Console.WriteLine($"Студент: {student4.Firstname} {student4.Lastname}");
            Console.WriteLine($"Идентификатор: {student4.Id}, Дата рождения: {student4.Birthday}");
            Console.WriteLine($"Категория алкоголизма: {student4.Category_alcoholic}");
            Console.WriteLine($"Объем выпитого: {student4.Volume} литров");
            Console.WriteLine($"Напиток: {student4.alco_Drink.name_Drink}, Процент алкоголя: {student4.alco_Drink.alco_Percent}%");
            Console.WriteLine($"Объем алкоголя от общего: {(cola.alco_Percent * student4.Volume) / volume_alcohol * 100}%");
            Console.WriteLine($"Объем жидкости от общего: {student4.Volume / volume_general * 100}%");
            Console.WriteLine();

            Console.WriteLine($"Студент: {student5.Firstname} {student5.Lastname}");
            Console.WriteLine($"Идентификатор: {student5.Id}, Дата рождения: {student5.Birthday}");
            Console.WriteLine($"Категория алкоголизма: {student5.Category_alcoholic}");
            Console.WriteLine($"Объем выпитого: {student5.Volume} литров");
            Console.WriteLine($"Напиток: {student5.alco_Drink.name_Drink}, Процент алкоголя: {student5.alco_Drink.alco_Percent}%");
            Console.WriteLine($"Объем алкоголя от общего: {(beer.alco_Percent * student5.Volume) / volume_alcohol * 100}%");
            Console.WriteLine($"Объем жидкости от общего: {student5.Volume / volume_general * 100}%");
            Console.WriteLine();
        }
        
        
        struct Alco_drink
        {
            public string name_Drink;
            public int alco_Percent;

            public Alco_drink(string name_drink, int alco_percent)
            {
                name_Drink = name_drink;
                alco_Percent = alco_percent;
            }
        }
        struct Student_info
        {
            public string Firstname;
            public string Lastname;
            public int Id;
            public DateTime Birthday;
            public string Category_alcoholic;
            public Alco_drink alco_Drink;
            public double Volume;

            public Student_info(string firstname, string lastname, int id, DateTime birthday, string category_alcoholic, Alco_drink alco_drink,
                double volume)
            {
                Firstname = firstname;
                Lastname = lastname;
                Id = id;
                Birthday = birthday;
                Category_alcoholic = category_alcoholic;
                alco_Drink = alco_drink;
                Volume = volume;
            }

        }
    }
}