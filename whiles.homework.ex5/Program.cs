using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiles.homework.ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numlist = new int[] {int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())
            , int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine())};

            int x = 0;
            int summ = 0;
            for (int i = 6; i > 0; i--)
            {
                if (numlist[x] % 2 == 0)
                {
                    summ += numlist[x];
                 
                }
                x += 1;
            }
            Console.WriteLine(summ);
            Console.ReadLine();
        }
    }
}