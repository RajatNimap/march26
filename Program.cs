
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
namespace March_26;
public class Program{

    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }

    }
    public class cusOrder
    {
        public int id { get; set; }
        public int custId { get; set; }

        public string custName { get; set; }
    }
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
        string[] arr2 = new string[] { "hello", "world", "Rajat", "Pandit" };
        float[] arr3 = new float[] { 1.0f, 2.3f, 4.3f, 9.3f };
        Program p = new Program();
        p.Elementarr(arr1);
        p.Elementarr(arr2);
        Genric<int[]> g = new Genric<int[]>();
        g.Elementarr(arr1);
        Genric<string> s = new Genric<string>();
        s.Elementarr(arr2);

        Console.WriteLine(p.Genarr(arr1));
        Console.WriteLine(p.Genarr(arr3));
        s.Parameter(1, "Rajat");


        Delegates dele = new Delegates();
        Mydelegate del = new Mydelegate(dele.greet);
        Mydelegate del2 = new Mydelegate(dele.greet1);
        del("Niraj");
        del2("Rajat");
        del += del2;

        // Finding distinct element in list
        var list1 = new List<int>() { 1, 2, 2, 3, 3, 4, 5 };

        //var DistincEle=list1.Distinct().ToList();
        // finding odd number and even number
        //  var list2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //var oddnum = list2.Where(x => x % 2 == 0).ToList();
        //var evennum = list2.Where(x => x % 2 != 0).ToList();
        //Sorting
        var list3 = new List<int>() { 5, 3, 6, 7, 2, 3, 1, 8 };
        var list4 = new List<int>() { };

        // var numAcen = list3.OrderBy(x => x).ToList();
        var Decen = list3.OrderByDescending(x => x).ToList();

        var firstEle = list3.First();
        var firstEle1 = list4.FirstOrDefault();
        var lastEle1 = list3.Last();
        Console.WriteLine(lastEle1);
        Console.WriteLine(firstEle1);
        var list5 = new List<int>() { 2, 4, 6, 8, 9 };
        var list6 = new List<int>() { 1, 3, 5, 7, 9 };

        var Istheodd = list5.Any(x => x % 2 == 0);
        var Istheeven = list6.Any(x => x % 2 == 0);
        var isthefodd1 = list5.All(x => x % 2 == 0);
        Console.WriteLine(isthefodd1);
        Console.WriteLine();
        Console.WriteLine(Istheodd);
        Console.WriteLine(Istheeven);

        var firstlist = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var take1 = firstlist.Take(5).ToList();
        var skip1 = firstlist.Skip(3).ToList();

        var mernum = new List<int>() { 1, 2, 3 };
        var merlett = new List<char>() { 'A', 'B', 'C' };

        var res = mernum.Zip(merlett, (num, letter) => ($"{num}-{letter}"));


        Console.WriteLine(res);
        // Aggregate

        var SumofNum = firstlist.Aggregate((accum, num) => accum += num);
        Console.WriteLine("Sum of aggregate number is " + SumofNum);



        foreach (var i in res)
        {
            Console.Write($" {i} ");
        }
        // Console.WriteLine(DistincEle);
        List<Order> orders = new List<Order>()
        {
            new Order()
            {
                ID = 1,
                Product = new List<string>() { "Product1", "Product2" }
            },
            new Order()
            {
                ID = 2,
                Product = new List<string>() { "Product3", "Product4" }
            },
            new Order()
            {
                ID = 3,
                Product = new List<string>() { "Product5", "Product6" }
            }
        };

        // Iterate through the list and display orders
        /*  foreach (var order in orders)
          {
              Console.WriteLine($"Order ID: {order.ID}");
              foreach (var product in order.Product)
              {
                  Console.WriteLine($" - {product}");
              }
          }
        */

        var list10 = new List<int>() {1,2,3,4,5,6,7,8,9,10};
        var allProduct = orders.SelectMany(order => order.Product);

        foreach(var i in allProduct)
        {
               Console.WriteLine(i);
        }
            
        
        Console.ReadKey();


    }
}