




namespace Lecture2
{
    delegate void MyDelegate();
    delegate void MyDelegate2(string s);
    delegate int MathOperations(int a, int b);//pointing to a function whose return type is int and has two parameters a and b
    delegate int MyDelegate1(int i, string s);

    // a delegate can refer to more than one functions 
    //references of functions can be added to or removed from delegates
    class Program
    {
        static int Add(int a, int b)
        {
            return a+b;
        }
        static int Subtract(int a, int b)
        {
            return a-b;
        }
        static void display()
        {
            Console.WriteLine("AOA Pakistan!!");
        }

        static void display1()
        {
            Console.WriteLine("Hello Pakistan!!");
        }

        static void display2(string s)
        {
            Console.WriteLine("AOA Pakistan!!"+ s);
        }
        static void Main(string[] args)
        {
            //without using delegate
            display();
            Console.WriteLine("\n");
            //using delegate
            MyDelegate d1 = new MyDelegate(display);//delegate d1 is referring to display function
            Console.WriteLine(d1.GetInvocationList());//?
            d1.Invoke();
            Console.WriteLine("\n");
            //or
            d1();
            Console.WriteLine("\n");

            d1+=display1;//now delegate d1 is referring to two functions: display and display1
            Console.WriteLine(d1.Method);

            d1();
            Console.WriteLine("\n");

            d1-=display;//now d1 is just pointing to display1
            Console.WriteLine(d1.Method);
            d1();
            Console.WriteLine("\n");
            d1=null;//points to null


            MathOperations op = Add;
            op+=Subtract;
            Console.WriteLine(op(2, 3));
            Console.WriteLine("\n");

            //agr delegate multiple functions ko refer kr raha hai aur wo functions  values return kr rhy hein tou aakhri walay function ki value consider/get hogi

            //multi-casting --> ?
        }
    }
}
















// QUESTION: if there is a class library which contains various functions and we call them in another libarary or main function.
//how do we use delegate that if we change out library or add or subtract some functions from it, we do not need to change the main where we are calling those functions

//code in class library
namespace ClassLibrary
{
    public delegate int MathOperations(int x, int y);
    public class MyLibrary
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Subtract(int x, int y)
        {
            return x-y;
        }
        public MathOperations GetFunction(int userInput)
        {
            MathOperations mop = null;
            if (userInput == 1)
            {
                mop=this.Add;
            }
            if (userInput == 2)
            {
                mop=this.Subtract;
            }

            return mop;
        }
    }

}


//code in main
namespace lec2
{
    class program
    {
        static void Main(string[] args)
        {
            //make library ka object
            MyLibrary lib = new MyLibrary();

            userinput=Console.ReadLine();
            var fn = lib.getFunction(userinput);
            Console.WriteLine(fn(3, 4));

        }
    }
}







