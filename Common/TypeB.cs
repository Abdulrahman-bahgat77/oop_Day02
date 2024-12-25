using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB:TypeA
    {
        //public void print() { 
        
        //    TypeA obj=new TypeA();
        //    //obj.X = 10;//privat
        //    //obj.Y = 20;//private
            
        //    //obj.M = 40;//private
        //    obj.Z = 30;//internal

        //}

        public TypeB()
        {
            X = 10;
            Y = 20;
            Z = 30;
           // M = 40;//invalid [private] not inherit
        }
    }
}
