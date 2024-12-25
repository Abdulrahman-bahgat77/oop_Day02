using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Day02.Inheritance
{
    internal class Child:Parent
    {
         
        public int Z { get; set; }
        public Child(int x,int y,int z):base(x,y)
        {
            
            Z = z;

        }
        public override string ToString()
        {
            return  $"({X},{Y},{Z})";
        }

        public new int product() //Masking ==new version of product
        {
            return base.product()* Z;
        }
    }
}
