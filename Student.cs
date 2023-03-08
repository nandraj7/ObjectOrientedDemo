using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDemo
{
    internal class Student
    {
        int num1 { get; set; }
        int num2 { get; set; }
        int result { get; set; }


        //Parameter Less Method
        public void SumOfInterger()
        {
            result = num1 + num2;
        }
    }
}
