using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИзМетодички.classes
{
    /*Домашнее задание 7.1 Реализовать класс для описания здания (уникальный номер здания,
    высота, этажность, количество квартир, подъездов). Поля сделать закрытыми,
    предусмотреть методы для заполнения полей и получения значений полей для печати.
    Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества
    квартир на этаже и т.д. Предусмотреть возможность, чтобы уникальный номер здания
    генерировался программно. Для этого в классе предусмотреть статическое поле, которое бы
    хранило последний использованный номер здания, и предусмотреть метод, который
    увеличивал бы значение этого поля.*/
    internal class Building
    {
        static uint numBuilding;
        double heightBuilding;
        byte floorsAmount;
        byte apartsAmount;
        byte entranceAmount;

        public uint numbuilding
        {
            get { return numBuilding; }
            set { numBuilding = value; }
        }
        public double heightbuilding
        {
            get { return heightBuilding; }
            set { heightBuilding = value; }
        }
        public byte floorsamount
        {
            get { return floorsAmount; }
            set {  floorsAmount = value; }
        }
        public byte apartsamount
        {
            get { return apartsAmount; }
            set { apartsAmount = value; }
        }
        public byte entranceamount
        {
            get { return entranceAmount; }
            set { entranceAmount = value; }
        }

        public void GenUniqiueNum()
        {
            numBuilding++;
        }
        public double FloorHeight()
        {
            return floorsAmount / heightBuilding;
        }
        public double AmountApartInEntrance()
        {
            return apartsAmount / entranceAmount;
        }
        public double AmountApartInFloor()
        {
            return apartsAmount / floorsAmount;
        }

        public void Print()
        {
            Console.WriteLine($"Номер здания:{numBuilding}\nВысота здания:{heightBuilding}\nКол-во этажей в здании:{floorsAmount}" +
                $"\nКол-во квартир в здании:{apartsAmount}\nКол-во подъездов в здании:{entranceAmount}\n");
            Console.WriteLine($"Высота этажа:{FloorHeight()}\nКол-во квартир в подъезде:{AmountApartInEntrance}\nКол-во квартир на этаж:{AmountApartInFloor}");
        }
    }
}
