using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeC:TypeA
    {
        public TypeC()
        {
            X = 10;
            Y = 20;// inherit as private
            Z = 30;
            // M = 40;//invalid [private] not inherit
        }
    }
}
