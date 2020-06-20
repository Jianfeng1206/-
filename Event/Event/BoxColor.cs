using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    class BoxColor
    {   
        public delegate void Onchanged(string color);
        //定义里面的颜色的选择
        //表明这是个事件
        public event Onchanged handler;
        string[] options = { "red","blue","green"};
        
        public void UserSelected(int index)
        {

            string color = options[index];

            if (handler != null)
            {
                handler.Invoke(color);
            }
        }



    }
}
