
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
namespace March_26;
public class Program{
        

    public void Elementarr<T>(T[] arr)
    {
        
        foreach(T item in arr)
        {
            Console.WriteLine(item);   
        }

       
    }
    public T Genarr<T>(T[] arr1)
    {
        dynamic sum = default(T);
        foreach (T item in arr1) {
            sum += item;
                  }  
        return sum;
    }
    
    public static void Main(string[] args)
    {

        /*  Genric<string> data1=new Genric<string>();
          data1.GetData = "Rajat Pandit";
          Console.WriteLine(data1.GetData);
       Genric<int> data2 = new Genric<int>()
       {
           GetData = 20
       };




   Genric<float> data3 = new Genric<float>();
       data3.GetData = 30.90f;
       Console.WriteLine(data3.GetData);
       Console.WriteLine(data2.GetData);
        */
        int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
        string[] arr2 = new string[] {"hello","world","Rajat","Pandit" };
        float[] arr3 = new float[] { 1.0f, 2.3f, 4.3f,9.3f };
        Program p=new Program();
        p.Elementarr(arr1);
        p.Elementarr(arr2);
        Genric<int[]> g = new Genric<int[]>();
        g.Elementarr(arr1);
        Genric<string> s=new Genric<string> ();
        s.Elementarr(arr2);

       Console.WriteLine(p.Genarr(arr1));
        Console.WriteLine(p.Genarr(arr3));
        s.Parameter(1, "Rajat");


        Delegates dele = new Delegates();
        Mydelegate del = new Mydelegate(dele.greet);
        Mydelegate del2 = new Mydelegate(dele.greet1);
        del("Niraj");
        del2("Rajat");
        del +=del2 ;

        var list1 = new List<int>();

        Console.ReadKey();


    }
}