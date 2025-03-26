
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
namespace March_26
{
    public class Genric<T>{

        private T data;
        public T GetData
        {
            get { return data; }
            set { data = value; }
        }

        public void Elementarr<T>(T[] arr)
        {

            foreach (T item in arr)
            {
                Console.WriteLine(item);
            }


        }
        public void Parameter<T, U>(T num1,U str1)
        {
            Console.WriteLine($"{num1} and valus is {str1}");
        }

    }



}