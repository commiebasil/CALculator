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
            Console.WriteLine("Калкулятор v 0.0.3");
            Console.WriteLine("--------------");
            Console.WriteLine("Введите первое число");
            string str = Console.ReadLine();
            bool a1 = double.TryParse(str, out double a);
            switch (a1)
            {
                case true:
                    Console.WriteLine("Введите второе число");
                    str = Console.ReadLine();
                    bool b1 = double.TryParse(str, out double b);
                    switch (b1)
                    {
                        case false:
                            Console.WriteLine("Ошибка. Код 1. Разрешено вводить только числа.");
                            Console.ReadKey();
                            break;
                        case true:
                            Console.WriteLine("Ещё одно число? да/нет");
                            string var = Console.ReadLine();
                            switch (var)
                            {
                                case "да":
                                    Console.WriteLine("Введите третье число");
                                    str = Console.ReadLine();
                                    bool c1 = double.TryParse(str, out double c);
                                    switch (c1)
                                    {
                                        case false:
                                            Console.WriteLine("Ошибка. Код 1. Разрешено вводить только числа.");
                                            Console.ReadKey();
                                            break;
                                        case true:
                                            double[] array1 = new double[4];
                                            array1[0] = a + b + c;
                                            array1[1] = a - b - c;
                                            array1[2] = a * b * c;
                                            array1[3] = a / b / c;
                                            Console.WriteLine("Результаты:");
                                            Console.WriteLine("Сложение: " + array1[0]);
                                            Console.WriteLine("Вычитание: " + array1[1]);
                                            Console.WriteLine("Умножение: " + array1[2]);
                                            Console.WriteLine("Деление: " + array1[3]);
                                            Console.ReadKey();
                                            break;



                                    }
                                    break;
                                case "нет":
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
                                    break;
                                default:
                                    Console.WriteLine("Ошибка. Код 2. Разрешено вводить только да/нет");
                                    Console.ReadKey();
                                    break;
                            }
                            break;
                    }
                    break;
                case false:
                    Console.WriteLine("Ошибка. Код 1. Разрешено вводить только числа.");
                    Console.ReadKey();
                    break;
            }
        } 
    }
}
