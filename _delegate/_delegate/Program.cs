using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _delegate
{
    public delegate void Compute(int i, int j);//定义委托Compute,两个参数i和j;方法签名和加减法一样。无非是多加了一个delegate关键字。
    class Program
    {
        private static void Add(int i, int j)//声明加法
        {
            Console.WriteLine("{0}", i + j);
        }
        private static void Sub(int i, int j)//声明减法
        {
            Console.WriteLine("{0}", i - j);
        }
        private static void Calculator(int i, int j, Compute Cal)//Calculator这个方法有三个参数，第三个Compute是之前定义的委托类型。
        {
            Cal(i, j);  //委托类型Compute定义的一个Cal变量。在给Cal赋值的时候动态地决定使用哪个方法
        }
        //委托是一个类，它定义了方法的类型，使得可以将方法当作另一个方法的参数来进行传递。
        /*static void Main(string[] args)
        {
            Calculator(2, 5, Add);
            Calculator(5, 2, Sub);
            Console.ReadLine();
        }*/
        //从此可以看出Compute和int都是数据类型，那么是不是可以定义两个变量，把方法赋给变量。  
        static void Main(string[] args)
        {
 //将方法绑定到委托
            /*Compute delegate1, delegate2;
            delegate1 = Add;
            delegate2 = Sub;
            Calculator(1,2, delegate1);//3
            Calculator(7,4, delegate2);//3
            Console.ReadLine();
           */ 
 //其实，委托还有一个特性不同于int或其他数据类型，它可以将多个方法绑定到同一个委托上。如下：
            /*Compute delegate1;
            delegate1 = Add;
            delegate1 += Sub;
            Calculator(5, 1, delegate1);
            Console.ReadLine();  //先输出加法为6，后输出减法为4;
             * */
//其实，我们可以不用Calculator方法，通过委托来直接调用Add方法或者Sub方法。如下：
            Compute delegate1;
            delegate1 = Add;
            delegate1 += Sub;
            delegate1(9, 2);
            Console.ReadLine();//和为11、差为7
        }
    }
}
