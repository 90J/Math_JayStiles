using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_JayStiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //set variables
            string userNum;
            int conNumber;
            int outputNumber;
            int x = 0;

            //get user input
            Console.Write("Please, enter a number: ");
            conNumber = Convert.ToInt32(Console.ReadLine());

            //do math things and output data
            while (x < 12)
                {
                x = x + 1;
                outputNumber = conNumber * x;
                Console.WriteLine(conNumber + "x" + x + "=" + outputNumber);

            }
        }
    }
}
