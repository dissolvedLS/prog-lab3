using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_laba3_1_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            int i;
            for (i = 0; i < n; i++)
                myArray[i] = i * i;
            for (i = 0; i < n; i++)
                Console.Write(myArray[i] + " ");
        }
    }
}
