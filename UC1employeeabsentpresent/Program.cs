using System;

namespace employeeabsentpresent
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Random obj = new Random();
            int empCheck = obj.Next(0,2);
            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("employeee is present");
            else
                Console.WriteLine("employee is absent");
            Console.ReadKey();
        }
    }
}
