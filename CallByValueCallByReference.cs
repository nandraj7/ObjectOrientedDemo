using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDemo
{
    internal class CallByValueCallByReference
    {
        public void CallByValue(int num1,int num2) 
        {
            num1 = 100;
            num2 = 200;
        }

        public void CallByReference(ref int num1, ref int num2)
        {
            num1= 100;
            num2 = 200;
        }
    }
}
