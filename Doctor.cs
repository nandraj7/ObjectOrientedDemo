using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDemo
{
    internal class Doctor
    {
        //Static Member
        public static int xyz { get; set; }

        //Non Static Member - Instance Member - Data Member
        public int Id { get; set; }
        public string Name { get; set; }
        public int GrossIncome { get; set; }
        public int IncomeTax { get; set; }
        public int NetIncome { get; set;}    //Property
        public int netIncom;                //Field

         //Non Value Returning Function
         public void GetData()
        {
            Console.WriteLine("Enter The Value For Id");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Value For Name");
            Name = Console.ReadLine();

            Console.WriteLine("Enter The Value For GrossIncome");
            GrossIncome = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Value For IncomeTax");
            IncomeTax = Convert.ToInt32(Console.ReadLine());

            NetIncome = CalculateNetIncome2();
        }

        //Non Value Returning Function Without Return Type
        public void PutData()
        {
            Console.WriteLine("Id =" + Id);
            Console.WriteLine("Name =" + Name);
            Console.WriteLine("GrossIncome =" + GrossIncome);
            Console.WriteLine("IncomeTax =" + IncomeTax);
            Console.WriteLine("NetIncome =" + NetIncome);

        }
        //Value Returning Method
        public int CalculateNetIncome2()
        {
            int result = GrossIncome - IncomeTax;

            return result;
        }







        #region Type Casting Demo
        //Type Casting Demo
        public string strId { get; set; }
        public char charId { get; set; }
        public static void CalculateNetIncome()             //Method
        {

            Doctor doctor = new Doctor();

            doctor.strId = "10";
            doctor.Id = Convert.ToInt32(doctor.strId);          //Explicite Type Casting

            doctor.charId = 'A';
            doctor.Id = doctor.charId;                          //Implicite Type Casting

        }
        #endregion

        //public static void CalculateNetIncome3()   //Method
        //{
        //    xyz = 0;                //Static Member
        //    CalculateNetIncome3();
        //    Doctor doctor = new Doctor();
        //    doctor.NetIncome = 4;
        //    doctor.NonStaticFunction();
        //}

        //public void NonStaticFunction()
        //{


        //}
    }
}
