using System;


namespace March_26
{

    public delegate void Mydelegate(string msg);

    public class Delegates
    {

        public void greet(string msg)
        {
            Console.WriteLine("Hello how are you " + msg);

        }
        public void greet1(string msg)
        {
            Console.WriteLine("Hello What are you doing " + msg);

        }
    }

}