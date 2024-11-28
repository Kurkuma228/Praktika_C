using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;

namespace project
{
    enum NameMonths
    {
        Январь,
        Февраль,
        Март,
        Апрель,
        Май,
        Июнь,
        Июль,
        Авугст,
        Сентябрь,
        Октябрь,
        Ноябрь,
        Декабрь
    }
    class HomeWork
    {
        /*Упражнение 6.1 Написать программу, которая вычисляет число гласных и согласных букв в
        файле. Имя файла передавать как аргумент в функцию Main. Содержимое текстового файла
        заносится в массив символов. Количество гласных и согласных букв определяется проходом
        по массиву. Предусмотреть метод, входным параметром которого является массив символов.
        Метод вычисляет количество гласных и согласных букв.*/
        public static void Ex1(string fileName)
        {
            string fileStrings = File.ReadAllText(fileName).ToLower();
            char[] fileChars = fileStrings.ToCharArray();
            CountChar(fileChars);
        }
        public static void CountChar(char[] chars)
        {
            int resVowels = 0;
            int resConsonants = 0;
            string vowels = "eyuioaйуеыаоэяию";
            string consonants = "qwrtpsdfghjklzxcvbnmцкнгшщзхфвпрлджчсмтб";
            foreach (char c in chars)
            {
                if (vowels.Contains(c))
                {
                    resVowels++;
                }
                else if (consonants.Contains(c))
                {
                    resConsonants++;
                }
            }
            Console.WriteLine($"Количество гласных = {resVowels}");
            Console.WriteLine($"Количество согласных = {resConsonants}");
        }

        /*Упражнение 6.2 Написать программу, реализующую умножению двух матриц, заданных в
        виде двумерного массива. В программе предусмотреть два метода: метод печати матрицы,
        метод умножения матриц (на вход две матрицы, возвращаемое значение – матрица).*/
        public static void Ex2()
        {
            try
            {
                Console.WriteLine("\nКоличество строк и столбцов ограничено 255");
                Console.WriteLine("\nВывод матрицы на печать");
                Console.WriteLine("Введите количество строк");
                byte rank = byte.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество столбцов");
                byte length = byte.Parse(Console.ReadLine());
                int[,] matrix1 = CreateMatrix(rank, length);
                PrintMatrix(matrix1);

                Console.WriteLine("\nУмножение двух матриц (Кол-во столбцов 1-ой матрицы должно быть = кол-ву строк 2-ой матрицы)");
                Console.WriteLine("Введите количество строк в первой матрице");
                byte rank1 = byte.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество столбцов в первой матрице");
                byte length1 = byte.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество строк во второй матрице");
                byte rank2 = byte.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество столбцов во второй матрице");
                byte length2 = byte.Parse(Console.ReadLine());
                if (length1 == rank2)
                {
                    PrintMatrix(MultiMatrix(rank1, length1, rank2, length2));
                }
                else
                {
                    Console.WriteLine("Ошибка кол-во столбцов 1-го не равно кол-ву строк 2-го");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("\nВведен неверный формат значения");
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"\n{e.Message}");
            }
        }
        public static int[,] CreateMatrix(byte rank, byte length)
            {
            Random rnd = new Random();
            int[,] matrix = new int[rank, length];
            for (int i = 0; rank > i; i++)
            {
                for (int j = 0; length > j; j++)
                {
                    matrix[i, j] = rnd.Next(-50, 50);
                }
            }
            return matrix;
        }
        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; matrix.GetUpperBound(0) + 1 > i; i++)
            {
                for (int j = 0; matrix.Length / (matrix.GetUpperBound(0) + 1) > j; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        public static int[,] MultiMatrix(byte rank1, byte length1, byte rank2, byte length2)
        {
            int[,] matrix1 = CreateMatrix(rank1, length1);
            int[,] matrix2 = CreateMatrix(rank2, length2);
            
            int[,] matrixMulti = new int[rank1, length2];
            for (int i = 0; rank1 > i; i++)
            {
                for (int  k = 0; length1 > k; k++)
                {
                    for (int  l = 0; length2 > l; l++)
                    {
                        matrixMulti[i, l] += matrix1[i, k] * matrix2[k, l];
                    }
                }
            }
            return matrixMulti;
        }
        /*Упражнение 6.3 Написать программу, вычисляющую среднюю температуру за год. Создать
        двумерный рандомный массив temperature[12,30], в котором будет храниться температура
        для каждого дня месяца (предполагается, что в каждом месяце 30 дней). Сгенерировать
        значения температур случайным образом. Для каждого месяца распечатать среднюю
        температуру. Для этого написать метод, который по массиву temperature [12,30] для каждого
        месяца вычисляет среднюю температуру в нем, и в качестве результата возвращает массив
        средних температур. Полученный массив средних температур отсортировать по
        возрастанию.*/
        public static void Ex3()
        {
            int[,] temperature = new int[12, 30];
            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    temperature[i, j] = rnd.Next(-40, 40);
                }
                
            }
            object[] sortArray = AverageTemp(temperature);
            Array.Sort(sortArray);
            Console.WriteLine("\nСредние значения в порядке возрастания");
            for (int i = 0; sortArray.Length > i; i++)
            {
                Console.Write(sortArray[i] + " ");
            }
        }
        public static object[] AverageTemp(int[,] temperature)
        {
            object[] averTemp = new object[12];
            int sumTemp = 0;
            for (int i = 0; i < 12; ++i)
            {
                for (int k = 0; k < 30; k++)
                {
                    sumTemp += temperature[i, k];
                }
                Console.WriteLine($"{i + 1} месяц = {sumTemp / 30}");
                averTemp[i] = sumTemp / 30;
            }
            return averTemp;
        }
        /*Домашнее задание 6.1 Упражнение 6.1 выполнить с помощью коллекции List<T>.*/
        public static void Ex4(string fileName)
        {
            List<char> fileChars = new List<char>();
            string fileStrings = File.ReadAllText(fileName).ToLower();
            foreach (char c in fileStrings)
            {
                fileChars.Add(c);
            }
            CountChar(fileChars);
        }
        public static void CountChar(List<char> chars)
        {
            int resVowels = 0;
            int resConsonants = 0;
            string vowels = "eyuioaйуеыаоэяию";
            string consonants = "qwrtpsdfghjklzxcvbnmцкнгшщзхфвпрлджчсмтб";
            foreach (char c in chars)
            {
                if (vowels.Contains(c))
                {
                    resVowels++;
                }
                else if (consonants.Contains(c))
                {
                    resConsonants++;
                }
            }
            Console.WriteLine($"Количество гласных = {resVowels}");
            Console.WriteLine($"Количество согласных = {resConsonants}");
        }
        /*Домашнее задание 6.2 Упражнение 6.2 выполнить с помощью коллекций
        LinkedList<LinkedList<T>>.*/
        public static void Ex5()
        {

        }
        /*Домашнее задание 6.3 Написать программу для упражнения 6.3, использовав класс
        Dictionary<TKey, TValue>. В качестве ключей выбрать строки – названия месяцев, а в
        качестве значений – массив значений температур по дням.*/
        public static void Ex6()
        {
            Random rnd = new Random();
            var months = new Dictionary<string, int[]>();
            string[] nameMonths = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Авугст", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            for (int i = 0; i < 12; i++)
            {
                int[] temperatures = new int[30];
                months.Add(nameMonths[i], [30]);
                for (int j = 0; j < 30; j++)
                {
                    temperatures[i] = rnd.Next(-80, 100);
                }
                months[nameMonths[i]] = temperatures;
            }

            List<double> averTemp = new List<double>();
            for (int i = 0;i < 12; i++)
            {
                averTemp.Add(AverageTempEx2(months[nameMonths[i]]));
            }
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"За {nameMonths[i]} средняя температура составляет {averTemp[i]}");
            }
        }
        public static double AverageTempEx2(int[] temperature)
        {
            int sumTemp = 0;
            double averTemp = 0;
            for (int i = 0; i < 30; ++i)
            {
                sumTemp += temperature[i];
                averTemp = sumTemp / 30;
            }
            return averTemp;
        }

        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Упражнение 6.1");
            Ex1("Text.txt");

            //Задание 2
            Console.WriteLine("\nУпражнение 6.2");
            Ex2();

            //Задание 3
            Console.WriteLine("\nУпражнение 6.3");
            Ex3();

            //Задание 4
            Console.WriteLine("\nДомашнее задание 6.1");
            Ex4("Text.txt");

            //Задание 5
            Console.WriteLine("\nДомашнее задание 6.2");
            Ex5();

            //Задание 6
            Console.WriteLine("\nДомашнее задание 6.3");
            Ex6();
        }
    }
}
