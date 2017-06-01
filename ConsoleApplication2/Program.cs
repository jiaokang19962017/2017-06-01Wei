using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    
    class Program
    {
        public static void PrintTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }
        static void Main(string[] args)
        {
            DateTimeDelegate dt = new DateTimeDelegate(PrintTime);
            dt();
            Calculate ca = new Calculate();
            CalDelegate cd = ca.Add;
            CalDelegate cd1 = ca.Minus;
            int result1 = cd1(3, 2);
            int result = cd(2, 3);
            Console.WriteLine(result1);
        }

    }
}
