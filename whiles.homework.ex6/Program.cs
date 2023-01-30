using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiles.homework.ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();

            bool y = false;

            for (int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                int x = int.Parse(Console.ReadLine());
                list1.Add(x);
                if (x == 77)
                {
                    y = true;
                }
            }
            if (y == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();

        }
    }
}
