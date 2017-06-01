using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public delegate int CalDelegate(int x, int y);
    class Calculate
    {
        /// <summary>
        /// 想加
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public  int Add(int num1,int num2)
        {
            return num1 + num2;
        }
        /// <summary>
        /// 相减
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int Minus(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
