using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
 
    /// <summary>
    /// 打招呼
    /// </summary>
    class Greet
    {
        public void Greeting(string name,GreetDelegate gd)
        {
            gd(name);
        }
       /* public void Greeting(string name, string language)
        {
            switch (language)
            {
                case "Cn":
                    Chinese(name);
                    break;

            }

        }*/



        /// <summary>
        /// 中国
        /// </summary>
        /// <param name="name"></param>
        public void Chinese(string name)
        {
            Console.WriteLine("你好" + name);
        }
        /// <summary>
        /// 英国
        /// </summary>
        /// <param name="name"></param>
        public void English(string name)
        {
            Console.WriteLine("Hello" + name);
        }
        /// <summary>
        /// 韩国
        /// </summary>
        /// <param name="name"></param>
        public void Korea(string name)
        {
            Console.WriteLine("韩国人" + name);
        }
    }
}
