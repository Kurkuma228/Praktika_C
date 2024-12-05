using ИзМетодички.classes;

namespace metodichka
{
    class Programm
    {
        static void Main(string[] args)
        {
            //Упражнения 7.1 - 7.3
            Console.WriteLine("Упражнения 7.1 - 7.3");
            Task1();
            //Домашнее задание 7.1
            Task2();
        }

        static void Task1()
        {
            /*Упражнение 7.1 Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
            банковского счета (использовать перечислимый тип из упр. 3.1). Предусмотреть методы для
            доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и
            вывести информацию об объекте класса на печать.*/

            /*Упражнение 7.2 Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы
            номер счета генерировался сам и был уникальным. Для этого надо создать в классе
            статическую переменную и метод, который увеличивает значение этого переменной.*/
            
            /*Упражнение 7.3 Добавить в класс счет в банке два метода: снять со счета и положить на
            счет. Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае
            положительного результата изменяет баланс.*/

            try
            { 
                BankAccount bankAcc = new BankAccount(0, 0, 0);
                bankAcc.GenAccountNumber();

                Console.WriteLine("Введите 1 для внесения денег. Введите 2 для снятия денег.\nЛюбое число или слово, кроме 1 и 2, сразу выведет на печать ваш счет");
                string check = Console.ReadLine();
                if (check == "1")
                {
                    Console.WriteLine("Введите сколько вы хотите внести");
                    decimal cash = decimal.Parse(Console.ReadLine());
                    bankAcc.Deposit(cash);
                }
                else if (check == "2")
                {
                    Console.WriteLine("Введите сколько вы хотите снять");
                    decimal cash = decimal.Parse(Console.ReadLine());
                    bankAcc.Withdraw(cash);
                }

                Console.WriteLine("Введите тип вашего счета: текущий или сберегательный");
                string accType = Console.ReadLine();

                if (accType.ToLower() == "сберегательный")
                {
                    bankAcc.accountType = AccountType.Сберегательный;
                    bankAcc.PrintAccBank();
                }
                else if (accType.ToLower() == "текущий")
                {
                    bankAcc.accountType = AccountType.Текущий;
                    bankAcc.PrintAccBank();
                }
                else
                {
                    Console.WriteLine("Введен неверный тип счета");
                }
            }
            catch (FormatException ex) 
            { Console.WriteLine(ex.Message); }
            catch (OverflowException ex)
            { Console.WriteLine(ex.Message); }
        }
        static void Task2()
        {
            /*Домашнее задание 7.1 Реализовать класс для описания здания (уникальный номер здания,
            высота, этажность, количество квартир, подъездов). Поля сделать закрытыми,
            предусмотреть методы для заполнения полей и получения значений полей для печати.
            Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества
            квартир на этаже и т.д. Предусмотреть возможность, чтобы уникальный номер здания
            генерировался программно. Для этого в классе предусмотреть статическое поле, которое бы
            хранило последний использованный номер здания, и предусмотреть метод, который
            увеличивал бы значение этого поля.*/
            try
            {
                Building building = new Building();
                building.GenUniqiueNum();
                Console.WriteLine("Введите высоту здания");
                building.heightbuilding = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество этажей в здании");
                building.floorsamount = byte.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество квартир в здании");
                building.apartsamount = byte.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество подъездов в здании");
                building.entranceamount = byte.Parse(Console.ReadLine());
                building.Print();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    enum AccountType
    {
        Сберегательный,
        Текущий
    }

}