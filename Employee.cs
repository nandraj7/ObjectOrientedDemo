using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDemo
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }


        public void GetData()
        {
            Console.WriteLine("Please Enter the Value for employee Id");
            this.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the Value for employee Name");
            this.Name = Console.ReadLine();

            Console.WriteLine("Please Enter the Value for employee Address");
            this.Address = Console.ReadLine();
        }

        public void PutData()
        {

            Console.WriteLine("Id=" + this.Id);
            Console.WriteLine("Name=" + this.Name); 
            Console.WriteLine("Address=" + this.Address);
        }

    }
}
