using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();


            for (int i = 1; i < 43; i++)
            {
                number.Add(i);
            }


            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {

                int b = rand.Next(1, number.Count);
                Console.Write(number[b] + " ");


                number.RemoveAt(b);
            }


            Console.Read();
        }
    }
}
