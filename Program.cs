using ObjectOrientedDemo;

public class Program
{
    public static void Main()
    {
        int num1 = 10;
        int num2 = 20;

        CallByValueCallByReference callByValueCallByReference = new CallByValueCallByReference();

        Console.WriteLine("Call By Value Before Calling To Function");
        Console.WriteLine($"Number1 = {num1} Number2 = {num2}");

        callByValueCallByReference.CallByValue(num1, num2);

        Console.WriteLine("Call By Value After Calling To Function");
        Console.WriteLine($"Number1 = {num1} Number2 = {num2}");



        Console.WriteLine("Call By Reference Before Calling To Function");
        Console.WriteLine($"Number1 = {num1} Number2 = {num2}");

        callByValueCallByReference.CallByReference(ref num1, ref num2);

        Console.WriteLine("Call By Reference After Calling To Function");
        Console.WriteLine($"Number1 = {num1} Number2 = {num2}");


        //-----______------______-----______------______-----______------______-----______------______-----


        //Arithmetic arithmetic = new Arithmetic();
        //arithmetic.Add(10, 20);


        //Arithmetic arithmetic1 = new Arithmetic();
        //arithmetic1.A = 20;
        //arithmetic1.B = 10;

        //Arithmetic arithmetic2 = new Arithmetic();
        //arithmetic2.Sub(arithmetic1);

        //int result = 10;
        //int num1 = 10, num2 = 20;

        ////Actual Parameter
        //arithmetic2.Mul(num1, num2, out result);
        //Console.WriteLine($"Multiplication of 10 And 20 is = {result}");

        //int resultnew = 10;
        //arithmetic2.Div(num1, num2, ref resultnew);
        //Console.Write($"Result = {resultnew}");


        //int modeResult = arithmetic.Mod(5, 2);
        //Console.WriteLine($"mod of Two Numbers =" + modeResult);

        //int additionResult = arithmetic.ArithmaticOperation(30, 20, out int substractionResult, out int multiplicationResult,
        //                                out int divisionResult, out int modResult);

        //Console.WriteLine($"Addition = {additionResult} Substraction = {substractionResult} Multiplication = {multiplicationResult} " +
        //                                $"division = {divisionResult} Mod = {modResult}");



        //-----______------______-----______------______-----______------______-----______------______-----


        //Console.WriteLine("Doctor 1 Object");
        //Doctor doctor1= new Doctor();
        //doctor1.GetData();
        //doctor1.PutData();

        //Console.WriteLine("Doctor 2 Object");
        //Doctor doctor2 = new Doctor();
        //doctor2.GetData();
        //doctor2.PutData();




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

