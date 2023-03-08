using ObjectOrientedDemo;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Doctor 1 Object");
        Doctor doctor1= new Doctor();
        doctor1.GetData();
        doctor1.PutData();

        Console.WriteLine("Doctor 2 Object");
        Doctor doctor2 = new Doctor();
        doctor2.GetData();
        doctor2.PutData();




        //Console.WriteLine("Employee1 Object Information");
        //Employee employee1 = new Employee();
        //employee1.GetData();
        //employee1.PutData();


        //CreateDemoObject();
    }

    public static void CreateDemoObject()
    {
        Employee object1 = new Employee();

        object1.Id = 10;
        object1.Name = "Amit";
        object1.Address = "Pune";

        Console.WriteLine("Object1 Information Id=" + object1.Id);
        Console.WriteLine("Name=" + object1.Name);
        Console.WriteLine("Address=" + object1.Address);


        Employee object2;
        object2 = new Employee();

        object2.Id = 20;
        object2.Name = "Vijay";
        object2.Address = "Mumbai";

        Console.WriteLine("object2 Information Id=" + object2.Id);
        Console.WriteLine("Name=" + object2.Name);
        Console.WriteLine("Address=" + object2.Address);


        Employee employee = new Employee();

        Console.WriteLine("Please Enter the Value for employee Id");
        employee.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Enter the Value for employee Name");
        employee.Name = Console.ReadLine();

        Console.WriteLine("Please Enter the Value for employee Address");
        employee.Address = Console.ReadLine();


        Console.WriteLine("employee Information Id=" + employee.Id);
        Console.WriteLine("Name=" + employee.Name);
        Console.WriteLine("Address=" + employee.Address);
    }


}

