using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPrograming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Find MaxNumber");
            int output = FindMaxNumber.FindMaxValueOfThree(11, 22, 33);
            Console.WriteLine(output);
            float floatoutput = FindMaxNumber.FloatMaxValueOfThree((float)111.3, (float)22.54, (float)3354.68);
            Console.WriteLine(floatoutput);
            string strigoutput = FindMaxNumber.StringMaxValueOfThree("Gopal", "Gopu", "Gokul");
            Console.WriteLine(strigoutput);
            Console.ReadKey();
        }
    }
}
