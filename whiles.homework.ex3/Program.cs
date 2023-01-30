using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiles.homework.ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numlist = new int[] {int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())
            , int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())};

            int[] truenums = new int[] { };

            int x = 0;
            int y = 0;
            for (int i = 5; i > 0; i--)
            {
                if (numlist[x] % 2 == 1)
                {
                    y += 1;
                }
                x += 1;
            }
            Console.WriteLine(y);
            Console.ReadLine();





        }
    }
}
