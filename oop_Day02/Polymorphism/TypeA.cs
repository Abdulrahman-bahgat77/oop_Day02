using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Day02.Polymorphism
{
    internal class TypeA
    {
     // automatic property
        public int A { get; set; }

        //ctor
        public TypeA(int a)
        {
            A = a;
        }

        public void myfunc1()
        {
            Console.WriteLine("Iam parent");
        }

        public virtual void myfunc2()
        {
            Console.WriteLine($"A={A}");
        }
    }
}
