using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDemo
{
    internal class Arithmetic
    {

        public int A { get; set; }
        public int B { get; set; }
        public void Add(int num1, int num2)     //Parameters or Arguments
        {
            int result = num1 + num2;

            // Console.WriteLine("Addition of" +num1+ "And" +num2+ "is =" +result);
            Console.WriteLine($"Addition of {num1} And {num2} is = {result}");
            // Addition of 10 And 20 is = 30

        }

        //Function Complex Arhuments or Parameter
        public void Sub(Arithmetic arth)
        {
            int result = arth.A - arth.B;
            Console.WriteLine($"Substraction of {arth.A} And {arth.B} is = {result}");
            //Substraction of 20 And 10 is = 10

        }

        //Formal Parameter
        public void Mul(int a, int b, out int result)            //Output Parameters or Arguments
        {
            result = a * b;
        }

        public void Div(int a, int b, ref int resultnew)        //Input-Output Parameters or Arguments
        {
            resultnew = resultnew + a / b;
        }

        public int Mod(int num1, int num2)
        {
            int result = num1 % num2;
            return result;
        }


        public int ArithmaticOperation(int a, int b, out int substractionResult, out int multiplicationResult,
                                        out int divisionResult, out int modResult)
        {
            int additionResult = a + b;
            substractionResult = a - b;
            multiplicationResult = a * b;
            divisionResult = a / b;
            modResult = a % b;

            return additionResult;
        }
    }
}
