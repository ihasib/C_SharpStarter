using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the first integer\n");
            string S1 = Console.ReadLine();
            int number1 = Convert.ToInt32(S1);


            Console.WriteLine("Please insert the second integer\n");
            string S2 = Console.ReadLine();
            int number2 = Convert.ToInt32(S2);

            int sum = Calculation.Add(number1,number2);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
