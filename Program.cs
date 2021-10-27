using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калкулятор v 0.0.2");
            Console.WriteLine("--------------");
            Console.WriteLine("Введите первое число");
            string str = Console.ReadLine();
            bool a1 = double.TryParse(str, out double a);
            if (a1)
            {
                Console.WriteLine("Введите второе число");
                str = Console.ReadLine();
                bool b1 = double.TryParse(str, out double b);
                if (b1)
                {
                    Console.WriteLine("ещё одно число? да/нет");
                    string var = Console.ReadLine();
                    if (var == "да")
                    {
                        Console.WriteLine("Введите третье число");
                        str = Console.ReadLine();
                        bool c1 = double.TryParse(str, out double c);
                        if (c1)
                        {
                            double[] array = new double[4];
                            array[0] = a + b + c;
                            array[1] = a - b - c;
                            array[2] = a * b * c;
                            array[3] = a / b / c;
                            Console.WriteLine("Результаты:");
                            Console.WriteLine("Сложение: " + array[0]);
                            Console.WriteLine("Вычитание: " + array[1]);
                            Console.WriteLine("Умножение: " + array[2]);
                            Console.WriteLine("Деление: " + array[3]);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Код ошибки 1. Разрешено вводить только цифры.");
                            Console.ReadKey();
                        }
                    }
                    if (var == "нет")
                    {
                        double[] array = new double[4];
                        array[0] = a + b;
                        array[1] = a - b;
                        array[2] = a * b;
                        array[3] = a / b;
                        Console.WriteLine("Результаты:");
                        Console.WriteLine("Сложение: " + array[0]);
                        Console.WriteLine("Вычитание: " + array[1]);
                        Console.WriteLine("Умножение: " + array[2]);
                        Console.WriteLine("Деление: " + array[3]);
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.WriteLine("Код ошибки 2. Можно вводить только да/нет.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Код ошибки 1. Разрешено вводить только цифры.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Код ошибки 1. Разрешено вводить только цифры.");
                Console.ReadKey();
            }
        }
    }
}
