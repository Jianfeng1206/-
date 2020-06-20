using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{  

    // 对继承语法的一个基本的复习
    class Child:Parent
    {

       public Child()
        {

            this.a = 45;

        }
            
 

        public override void Eat()
        {
            base.Eat();
            base.a = 6;
        }
    }
}
