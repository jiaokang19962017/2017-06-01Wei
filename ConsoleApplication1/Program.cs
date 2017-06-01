using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    /// <summary>
    /// 委托和类是一个级别的,都定义在命名空间下
    /// 定义一个没有参数也没有返回值的委托
    /// </summary>
    public delegate void MyDelegate();
    class Program
    {
        static void GetInfo()
        {
            Console.WriteLine("这是一个方法");
        }
        /// <summary>
        /// 1.定义一个委托:委托名字MyDelegate
        /// 2.声明一个委托变量,实例化一个委托对象,并把一个传送到委托中
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            MyDelegate md = new MyDelegate(GetInfo);
            md();//调用委托

            //2.
            MyDelegate md1 = GetInfo;
            md1();
        }
    }
}
