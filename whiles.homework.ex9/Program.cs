using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiles.homework.ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> evenlist = new List<int>();
            List<int> oddlist = new List<int>();

            for (int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                int x = int.Parse(Console.ReadLine());
                if (x%2 == 0)
                {
                    evenlist.Add(x);
                }
                else
                {
                    oddlist.Add(x);
                }
            }
            if (evenlist.Count > oddlist.Count)
            {
                Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("odd number");
            }
            Console.ReadLine();
        }
    }
}
