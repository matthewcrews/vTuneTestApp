using System;
using System.Linq;
using System.Collections.Generic;

namespace listadd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting calculation...");
            List<int> numbers = Enumerable.Range(1, 10000).ToList();
            for (int i = 0; i < 100000; i++)
            {
                ListAdd(numbers);
            }

            Console.WriteLine("Calculation complete");
        }

        static int ListAdd(List<int> candidateList)
        {
            int result = 0;
            foreach (int item in candidateList)
            {
                result += item;
            }

            return result;
        }
    }
}