using System;
//1. WAP to overload add method


namespace MethodOverloadingExamples
{
    public class AddMethod
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b,int c)
        {
            return a + b+c;
        }
        public double Add(int a, double b)
        {
            return a + b;
        }
        public double Add(int a, float b)
        {
            return a + b;
        }
        public double Add(double a, int b)
        {
            return a + b;
        }
        public double Add(float a, int b)
        {
            return a + b;
        }
        public double Add(float a, double b)
        {
            return a + b;
        }
    }
}
