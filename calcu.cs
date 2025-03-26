using System;

public class Hello
{

    public class Calculator
    {

        public Calculator(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public int add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        public double div(int a, int b)
        {
            return a / b;
        }


    }
    public static void Main(string[] args)
    {

        Calculator cal = new Calculator(12, 34);
        //  cal.add(2,3);
        Console.WriteLine(cal.add(10, 30));
        Console.WriteLine(cal.sub(40, 30));
        Console.WriteLine(cal.mul(4, 7));
        Console.WriteLine(cal.div(10, 3));

        Console.WriteLine("hello world");
    }
}