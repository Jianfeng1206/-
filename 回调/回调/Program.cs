using System;
using System.Drawing;

namespace 回调
{
    class Program
    {
        static void OnColorChanged(string color)
        {
            Console.WriteLine("使用颜色:" + color);

            // 说明这个函数是可以去自定义的。。。。


        }
        static void Main(string[] args)
        {
            ColorBox box = new ColorBox();
            // 注册回调

            box.handler = new ColorBox.ChangeHandler(Program.OnColorChanged);

            // 用户点击
            box.UserSelected(0);


        }
    }
}
