using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Parent
    {
        public int a = 5;

        public virtual void  Eat()
        {
          

            Console.WriteLine("i like it");
        }
    }
}
