using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeB
    {
        private int num1;
        internal int num2;
        public int num3;

        void fun01()
        { 
            TypeA typeA = new TypeA(); //Valid because Type is in the same project

            TypeB typeB = new TypeB(); //Valid because Type is in the class project

            typeB.num1 = 1; //valid
            typeB.num2 = 2; //valid
            typeB.num3 = 3; //valid

        }
    }
}
