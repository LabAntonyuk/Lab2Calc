using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приложение позволяет выполнять следующие операции:");
            Console.WriteLine("+ - сложить A и В");
            Console.WriteLine("- - вычесть В из А");
            Console.WriteLine("* - умножить А на В");
            Console.WriteLine("/ - разделить А на В ");
            String Ans = "1";
            while (Ans == "1")
            {
                Console.WriteLine("Введите число А:");
                String A = Console.ReadLine();
                Console.WriteLine("Введите число B:");
                String B = Console.ReadLine();
                Console.WriteLine("Введите операцию:");
                String Op = Console.ReadLine();
                float res;
                try
                {
                    res = Сounting(A, B, Op);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверные данные!");
                }
                Console.WriteLine("Нажмите 1, если желаете выполнить новую операцию, и любую другую клавишу, если желаете выйти.");
                Ans = Console.ReadLine();
            }
        }

        private static float Сounting(string A, string B, string Op)
        {
            float a = float.Parse(A);
            float b = float.Parse(B);
            float res = 0;
            switch (Op)
            {
                case "+":
                    {
                        res = a + b;
                        Console.WriteLine("Ответ: {0}", res);
                        break;
                    }
                case "-":
                    {
                        res = a - b;
                        Console.WriteLine("Ответ: {0}", res);
                        break;
                    }
                case "*":
                    {
                        res = a * b;
                        Console.WriteLine("Ответ: {0}", res);
                        break;

                    }
                case "/":
                    {
                        res = a / b;
                        Console.WriteLine("Ответ: {0}", res);
                        break;
                    }
                default: Console.WriteLine("Недопустимая операция"); break;
            }
            return res;
        }
    }
}
