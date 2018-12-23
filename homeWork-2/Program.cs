using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine();

            double firstNumber, secondNumber, thirdNumber, sum;
            firstNumber = double.Parse(Console.ReadLine());
            secondNumber = double.Parse(Console.ReadLine());
            thirdNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(firstNumber + "  " + secondNumber + "  " + thirdNumber);



            Console.WriteLine();
            Console.WriteLine("Задание 2");
            Console.WriteLine();


            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);



            Console.WriteLine();
            Console.WriteLine("Задание 3");
            Console.WriteLine();


            Console.WriteLine("Введите количество сантиметров");
            int centimeters = int.Parse(Console.ReadLine());


            int centimetersInMeters = 100;
            int meters = centimeters / centimetersInMeters;

            Console.WriteLine("Полных метров: " + meters);



            Console.WriteLine();
            Console.WriteLine("Задание 4");
            Console.WriteLine();


            Console.WriteLine("Введите количество дней");
            int days = int.Parse(Console.ReadLine());


            int daysInWeek = 7;
            int week = days / daysInWeek;

            Console.WriteLine("Прошло недель: " + week);



            Console.WriteLine();
            Console.WriteLine("Задание 5");
            Console.WriteLine();


            Console.WriteLine("Введите двузначное число");
            int numbers = int.Parse(Console.ReadLine());


            int onesInTens = 10;
            int tens = numbers / onesInTens;
            int ones = numbers - tens * onesInTens;

            Console.WriteLine("Десятков: " + tens);
            Console.WriteLine("Единиц: " + ones);
            Console.WriteLine("Сумма цифр: " + (ones + tens));
            Console.WriteLine("Произведение цифр: " + ones * tens);



            Console.WriteLine();
            Console.WriteLine("Задание 6");
            Console.WriteLine();


            bool A = true, B = false, C = false;

            Console.WriteLine("A или B");
            if (A || B)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.WriteLine("A и B");
            if (A && B)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.WriteLine("B или C");
            if (B || C)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }



            Console.WriteLine();
            Console.WriteLine("Задание 7");
            Console.WriteLine();


            Console.WriteLine("Введите радиус круга");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону квадрата");
            double sideSquare = double.Parse(Console.ReadLine());


            double diameter = 2 * radius;
            double areaCircle = radius * radius * Math.PI;
            double areaAquare = sideSquare * sideSquare;

            if (areaCircle > areaAquare)
            {
                Console.WriteLine("Площадь круга больше площади квадрата");
            }
            else if (areaCircle < areaAquare)
            {
                Console.WriteLine("Площадь круга меньше площади квадрата");
            }
            else
            {
                Console.WriteLine("Площади фигур равны");
            }



            Console.WriteLine();
            Console.WriteLine("Задание 8");
            Console.WriteLine();


            Console.WriteLine("Введите объем первого тела");
            double firstVolume = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите массу первого тела");
            double firstWeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите объем второго тела");
            double secondVolume = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите массу второго тела");
            double secondWeight = double.Parse(Console.ReadLine());


            double firstDensity = firstWeight / firstVolume;
            double secondDensity = secondWeight / secondVolume;

            if (firstDensity > secondDensity)
            {
                Console.WriteLine("Плотность первого тела больше");
            }
            else if (firstDensity < secondDensity)
            {
                Console.WriteLine("Плотность второго тела больше");
            }
            else
            {
                Console.WriteLine("Плотности тел равны");
            }



            Console.WriteLine();
            Console.WriteLine("Задание 9");
            Console.WriteLine();


            Console.WriteLine("Введите напряжение первой цепи");
            double firstV = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сопротивление первой цепи");
            double firstR = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите напряжение второй цепи");
            double secondV = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сопротивление второй цепи");
            double secondR = double.Parse(Console.ReadLine());


            double firstI = firstV / firstR;
            double secondI = secondV / secondR;

            if (firstI > secondI)
            {
                Console.WriteLine("Меньший ток протекает во второй цепи");
            }
            else if (firstI < secondI)
            {
                Console.WriteLine("Меньший ток протекает в первой цепи");
            }
            else
            {
                Console.WriteLine("Сила тока в цепях одинакова");
            }



            Console.WriteLine();
            Console.WriteLine("Задание 9");
            Console.WriteLine();

            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            int value = int.Parse(Console.ReadLine());
            for (int i = 10; i <= value && value > 10; i++)
            {
                Console.WriteLine(i * i);
            }
            Console.WriteLine();

            value = int.Parse(Console.ReadLine());
            for (int i = value; i <= 50 && value < 50; i++)
            {
                Console.WriteLine(i * i * i);
            }
            Console.WriteLine();

            int firstValue = int.Parse(Console.ReadLine());
            int secondValue = int.Parse(Console.ReadLine());
            for (int i = firstValue; i <= secondValue; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
