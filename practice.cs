

using System;
public class nameprint
{

    public class showBrand
    {
        public string BrandName;
        public void showbrandname()
        {
            Console.WriteLine("it is great " + BrandName);
        }

    }
    public void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public void Add(int n, string s)
    {
        Console.WriteLine($" Your name is {s} and your lucky number is {n}");
    }
    public void Add(int a, int b, int c)
    {
        Console.WriteLine(a + b + c);
    }
    public static void Add1(params int[] n)
    {
        int sum = 0;
        foreach (var i in n)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }
    public static void Concating(params string[] str)
    {
        /*  string str1="";
          foreach(var i in str){
              str1+=" "+i;
          } */

        Console.Write(string.Join(" ", str));
    }

    public bool anangram(string str, string str1)
    {

        if (str.Length != str1.Length)
        {
            return false;
        }
        char[] ch = str.ToCharArray();
        char[] ch1 = str1.ToCharArray();

        Array.Sort(ch);
        Array.Sort(ch1);
        return new string(ch) == new string(ch1);

    }
    public static void Main(string[] args)
    {
        // Console.WriteLine("Enter your Name");
        //string s=Console.ReadLine();
        //Console.WriteLine($"Your Name is {s} enjoy your day");
        showBrand br1 = new showBrand();
        br1.BrandName = "BMW";
        br1.showbrandname();
        Add1(1, 2, 3, 4, 5, 6, 7, 87);
        Concating("Rajat", "Pandit");
        Console.WriteLine();
        nameprint np = new nameprint();
        np.Add(19, 23);
        np.Add(48, 39, 53);
        np.Add(7, "Rajat Pandit");
        Console.WriteLine(np.anangram("Rajat", "tajaR"));

    }
}