using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4isla
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var znak = Console.ReadLine();
            var result = 0.0;
            var chetnoiline="";
            if (znak == "+")
            {
                result = a + b;
                if (result % 2 == 0)
                    chetnoiline = "even";
                else
                    chetnoiline = "odd";
            }
            if (znak == "-")
            {
                result = a - b;
                if (result % 2 == 0)
                    chetnoiline = "even";
                else
                    chetnoiline = "odd";
            }
            if (znak == "*")
            {
                result = a * b;
                if (result % 2 == 0)
                    chetnoiline = "even";
                else
                    chetnoiline = "odd";
            }
            if (znak == "/")
            {
                result = a / b;
            }
            if (znak == "%")
            {
                result = a % b;
            }
            Console.WriteLine("{0} {1} {2} = {3} - {4}", a, znak, b, result, chetnoiline);
        }
    }
}
