using System;
using System.Collections.Generic;
using System.Text;

namespace 回调
{
    class ColorBox
    {
        public string[] color = { "red", "blue", "gree" };

        //当选中颜色的时候，触发回调
        // 定义为改变事件
        public delegate void ChangeHandler(string color);
        //实例化委托。
        public ChangeHandler handler;
        public void UserSelected(int index)
        {
            string color1 = color[index];
            // 调用回调的方法。。。


            if (handler != null)
                handler.Invoke(color1);




        }
    }
}
