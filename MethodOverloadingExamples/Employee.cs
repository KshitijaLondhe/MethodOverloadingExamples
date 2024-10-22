using System;
using System.Threading;
//2. WAP to overload constructor in Employee class


namespace MethodOverloadingExamples
{
    public class Employee
    {
        private int id;
        private string name;
        private double salary;
       
        public Employee()
        {
            Console.WriteLine("Non parametric Constructor");
        }
        public Employee(int eid,string ename,double esalary)
        {
            id = eid;
            name = ename;
            salary = esalary;
        }

        public Employee(string ename, double esalary)
        {
       
            name = ename;
            salary = esalary;
        }

        public string Display()
        {
            return $"Id:{id} Name:{name} Salary:{salary}";
        }
    }
}
