using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public delegate void DateTimeDelegate();
    class Test
    {
      
        static void DoSomething(DateTimeDelegate dt)
        {
            Console.WriteLine("第一步");
            Console.WriteLine("第二步");
            dt();
          //  Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine("第四步");
            Console.WriteLine("第五步");
        }


    }
}
