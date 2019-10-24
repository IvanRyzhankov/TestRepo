using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moduel1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Variable variable = new Variable();
            variable.Change();
            Console.WriteLine($"Variable a = {variable.a}. Variable b = {variable.b}");
            Console.ReadKey();
        }
    }
}
