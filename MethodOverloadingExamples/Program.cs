using System;

namespace MethodOverloadingExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Code For Add Method Overloading
            /* AddMethod ad = new AddMethod();
             Console.WriteLine("Addition :"+ad.Add(10,20));
             Console.WriteLine("Addition :" + ad.Add(10, 20.05));
             Console.WriteLine("Addition :" + ad.Add(10.05, 20));
             Console.WriteLine("Addition :" + ad.Add(10f, 20));
             Console.WriteLine("Addition :" + ad.Add(10, 20f));
             Console.WriteLine("Addition :" + ad.Add(10f, 20.05));
            */

            //Code For Employee constructor overloading
            /* Employee e1 = new Employee();
             Console.WriteLine(e1.Display());
             Employee e2 = new Employee(101,"Raj",45000);
             Console.WriteLine(e2.Display());
             Employee e3 = new Employee("Kritika", 45000);
             Console.WriteLine(e3.Display());*/

            //Code For Payment
            Payment p1 = new Payment();
            p1.PayBill(1000);
            Payment p2 = new Payment();
            p2.PayBill(1000,"PhonepPay");

        }
    }
}
