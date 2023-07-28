using math_operations_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_operations_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            operation option = new operation();

            option.SetOption(20, 4);
            Console.WriteLine(option);
            Console.ReadLine();
        }
    }
}
