using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiles.homework.ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numlisttrue = new List<int>();
            for (int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == 5)
                {
                    numlisttrue.Add(x);
                }
            }
            Console.WriteLine(numlisttrue.Count);
            Console.ReadLine();

        }
    }
}