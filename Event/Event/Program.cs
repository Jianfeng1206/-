using System;
using System.Runtime.CompilerServices;

namespace Event
{
    class Program
    {


        // 注册事件
        public static void changed(string color)
        {
            Console.WriteLine("the selected is "+color);

        }
        // 去写一个回调的方法



        //  去手动写一个事件，并手动田间
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // 去新建一个按钮
            BoxColor bc = new BoxColor();
            //对此按钮的点击事件进行注册，在使用

            //event倒底是个什么东西？
         //   可以认为是一种特殊的写法，相当于:
         //   List<ChangeHandler> Handlers;
          //  里面可以存储多个回调方法。

          //

            // 注册回调了
            bc.handler+= new BoxColor.Onchanged(Program.changed);
            bc.UserSelected(0);

        }
    }
}
