using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Day02.Polymorphism
{
    internal class TypeB:TypeA
    {
        public int B { get; set; }

        //overriding:
        //new key word
        //override key word

        public TypeB(int a,int b):base(a)
        {
            B = b;
        }

        //To apply override using verride key word
        // must be inherit from parent by[public-virtual]

        public new void  myfunc1()
        {
            Console.WriteLine("iam child");
        }

        public override void myfunc2()
        {
            Console.WriteLine($"A={A}\nB={B}");
        }

    }
}
