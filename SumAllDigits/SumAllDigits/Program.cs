using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAllDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            long digits;
            digits = long.Parse(Console.ReadLine());

            while (digits > 9)
            {
                int elements = 1;
                long sum = 0;

                long one_num = 0;
                long power = 0;

                elements = digits.ToString().Length - 1;

                while (elements > -1)
                {
                    power = (long)System.Math.Pow(10, elements);
                    one_num = digits / power;



                    sum += one_num;
                    digits -= one_num * power;

                    elements--;


                }
                digits = sum;



            }
            Console.WriteLine((long)digits);
            Console.ReadKey();
        }
    }
}
