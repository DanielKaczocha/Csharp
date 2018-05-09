using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskSharp
{


    class Program
    {
        static void Main(string[] args)
        {
            string cc = "";
            cc = Console.ReadLine();


            char[] Icc = new char[cc.Length];


            for (int i = 0; i < cc.Length; i++)
            {
                if (i > (cc.Length - 5))
                {
                    Icc[i] = cc[i];

                }
                else
                {
                    Icc[i] = '#';
                }
            }
            Console.WriteLine(Icc);
            Console.ReadKey();
        }
    }
}
