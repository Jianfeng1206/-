using System;

namespace ConsoleApp1
{

    public delegate void Mydog( );
   // 

    class Program
    {

       
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // delegate是回调的一种，类似于c++.系统调用自己写的API
            // 方法的描述，函数名，参数类型，返回类型
            // 对同一类型的函数如何做出规定了

            // 如何使用标准术语对上面的方法做出归类了

            // 是一种委托类型，对此种函数的一种声明
            // 是参数为int,返回数值为 void的函数类型

            Example ex = new Example();
            //传参的时候要指定某个对象的方法
            Mydog mg = new Mydog(ex.Test);
            mg();
            //委托的两种调用方式
            mg.Invoke();



        }
    }
}
