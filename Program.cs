
//**********************************************************
//* Практическая работа №4                                 *
//* Выполнил: Архипов В.И., группа 2-ИСП-22-оКФ            *
//* Задание: составить программу работы линейного алгоритма*
//**********************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа №4";

            double a, b, c, S;
            double v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12,v13,v14;
            Console.WriteLine("Здравствуйте!");
            Console.Write("Введите a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c = ");
            c = Convert.ToDouble(Console.ReadLine());


            v1 = Math.Sqrt(c);
            v2 = Math.Pow(b, 4);
            v3 = 3 * b;
            v4 = Math.Abs(v3);
            v5 = Math.Pow(a, 1 / v4);
            v6 = v5 * v2;
            v7 = v1*v6;
            v8 = Math.Pow(10, 1/3f); // это кубический корень.
            v9 = v8 + v7;
            v10 = Math.Log10(v9);
            v11 = Math.Pow(c,-2);
            v12 = a * b * v11;
            v13= Math.Pow(Math.E, v12);
            v14 = v10 + v13;
            S = v14;
            Console.WriteLine("Результат: S = {0:#.#####}", S);
            Console.WriteLine("Спасибо,Досвидание!");
            Console.ReadKey();

        }
    }
}