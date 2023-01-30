using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace whiles.homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 0;
            int[] list1 = new int[] { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())};
            for (int i = 5; i > 0; i--)
            {
                Console.Write(list1[x] + " ");
                x += 1;
            }
            Console.ReadLine();
        }
    }
}
