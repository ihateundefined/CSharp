using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250509_delegate
{
    internal class Program
    {
        delegate int CalcDel(int x, int y);
        
        static int Plus(int x, int y)
        {
            return x + y;
        }

        static int Minus(int x, int y)
        {
            return x - y;
        }

        static void Main(string[] args)
        {
            CalcDel del1 = new CalcDel(Plus);
            int result1 = del1(10, 20);
            Console.WriteLine(result1);

            CalcDel del2 = new CalcDel(Minus);
            int result2 = del2(10, 20);
            Console.WriteLine(result2);
        }
    }
}
