//9/3/2022


//github lec 19 --> delegates
//github lec 20 --> action, func delegates


//delegates
using System;
//Anonymous functions
//two types
//1- anonymous methods
//2- lambda statements
namespace lec3
{
    delegate void MyDelegate();
    delegate void MyDelegate2(int a);
    delegate int MyDelegate3(int a);
    delegate int MyDelegate4(string a);

    delegate void Count();
    delegate void Count1(int a);
    delegate int Count2(int a);
    class Program
    {
        static void display()
        {
            Console.WriteLine("AOA Pakistan!");
        }
        public static void Main(string[] args)
        {
            ////method 1
            //MyDelegate d1 = new MyDelegate(display);
            //d1();

            //Console.WriteLine("\n\n!!!!ANONYMOUS FUNCTIONS!!!!\n");
            ////method 2
            ////anonymous function
            //MyDelegate d2 = delegate
            // {
            //     Console.WriteLine("AOA Pakistan!");
            // };
            //d2();
            ////
            //MyDelegate2 d3 = delegate (int a)
            //{
            //    Console.WriteLine(a);
            //};
            //d3(12);
            ////
            //MyDelegate3 d4 = delegate (int a)
            //{
            //    Console.WriteLine(a);
            //    return a;
            //};
            //Console.WriteLine(d4(13));
            ////
            //MyDelegate4 d5 = delegate (string a)
            //  {
            //      Console.WriteLine(a);
            //      return a.Length;
            //  };
            //Console.WriteLine(d5("laiba"));



            ////count
            //Count c = delegate ()
            //  {
            //      int sum = 0;
            //      for(int i=1;i<10;i++)
            //      {
            //          sum+=i;
            //      }
            //      Console.WriteLine(sum);
            //  };
            //c();

            ////count1
            //Count1 c1 = delegate (int a)
            //  {
            //      int sum = 0;
            //      for (int i = 1; i<a; i++)
            //      {
            //          sum+=i;
            //      }
            //      Console.WriteLine(sum);
            //  };
            //c1(12);
            ////count2
            //Count2 c2 = delegate (int a)
            //  {
            //      int sum = 0;
            //      for (int i = 1; i<a; i++)
            //      {
            //          sum+=i;
            //      }
            //      return sum;
            //  };
            //Console.WriteLine(c2(50));




            //Console.WriteLine("\n\n!!!!LAMBDA STATEMENTS!!!!\n");

            //MyDelegate md2 = ()=>
            //{
            //    Console.WriteLine("AOA Pakistan!");
            //};
            //md2();
            ////
            //MyDelegate2 md3 =(int a)=> Console.WriteLine(a);
            //md3(12);
            ////
            //MyDelegate3 md4 = (int a)=> 
            //{
            //    Console.WriteLine(a);
            //    return a;
            //};
            //Console.WriteLine(d4(13));
            ////
            //MyDelegate4 d5 = delegate (string a)
            //{
            //    Console.WriteLine(a);
            //    return a.Length;
            //};
            //Console.WriteLine(d5("laiba"));



            //Console.WriteLine("\n\n!!!!LAMBDA EXPRESSIONS!!!!\n");

            //MyDelegate mdd2 = () => Console.WriteLine("AOA Pakistan!");
            //d2();
            ////
            //MyDelegate2 mdd3 = (int a) => Console.WriteLine(a);
            //d3(12);












            //built-in delegates nby microsoft
            //action-->void
            //func-->to return

            Action action = () => Console.WriteLine("using action delegate");
            action();

            //action can take 16 parameters at max, there are total 17 variations of action, one is that which takes no parameter and other 16 take parameters
            //Action a=()
            //Action a1=(int x,)
            //ACtion a2=(int x, int y)
            //ACtion a2=(int x, int y, int z)

            //Func<string, double, int> func = () => x=(string i,double k)
        }
    }
}









//WPF FORMS