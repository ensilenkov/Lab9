using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Введите первое число ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число ");
                int b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите мат.действие 1-сложение; 2-вычитание; 3-умножение; 4- деление");
            int mat = Convert.ToInt32(Console.ReadLine());
            decimal result;

            try
            {
                if (mat > 0 && mat < 5)

                {
                    switch (mat)
                    {
                        case 1:
                            {
                                result = a + b;
                                Console.WriteLine("Результат {0}", result);
                                break;
                            }
                        case 2:
                            {
                                result = a - b;
                                Console.WriteLine("Результат {0}", result);
                                break;
                            }
                        case 3:
                            {
                                result = a * b;
                                Console.WriteLine("Результат {0}", result);
                                break;
                            }
                        case 4:
                            {

                                result = a / b;
                                Console.WriteLine("Результат {0}", result);
                                break;

                            }
                    }


                }
                else Console.WriteLine("Введено некоректное действие!");
            }
            catch { Console.WriteLine("Ввод некорректных данных"); };


            Console.ReadKey();
        }
    }
}
