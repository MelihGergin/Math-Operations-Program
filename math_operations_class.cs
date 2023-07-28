using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_operations_class
{
    public class operation
    {
        public int a1;
        public int a2;

        public void SetOption(int a1, int a2)
        {
            Console.WriteLine("Welcome to the math operations program!");
            Console.WriteLine("Total           : " + (a1 + a2));
            Console.WriteLine("Extraction      : " + (a1 - a2));
            Console.WriteLine("Division        : " + (a1 / a2));
            Console.WriteLine("Multiplication  : " + (a1 * a2));
            Console.ReadLine();
        }
    }
}
