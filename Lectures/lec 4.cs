//events
//notes lec #4


//using System;
//namespace Events
//{
//    delegate void MyEventHandler();

//    //publisher class
//    class Button
//    {
//        public event MyEventHandler click;//defining event

//        public void OnClick()
//        {
//            if (click!=null)
//            {
//               //firing event
//                click();
//            }
//        }
//    }


//    class MyClass
//    {
//        public void MyEventHandlerFunction()
//        {
//            Console.WriteLine("Perform this action.....");
//        }
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Button button = new Button();
//            //+= is used to register an event
//            //1-- using lambda statement
//            button.click+=() => Console.WriteLine("A click event is fired.");//event is listened

//            //2--using event handler claass/function
//            MyClass myClass = new MyClass();
//            button.click+=myClass.MyEventHandlerFunction;

//            //3---using anonymous function
//            button.click +=  delegate
//             {
//                 Console.WriteLine("AOA Pakistan!");
//             };

//            //firing the event
//            button.OnClick();//button clicked
//        }
//    }

//}






////question: there is a class my array list class. whenever data is added to the array list in this class, an event is fired
//using System;
//using System.Collections;

//namespace FirinigEventsOnAddingData
//{
//    delegate void MyEventHandler();
//    class MyArrayList : ArrayList
//    {
//        //defining the event
//        public event MyEventHandler Added;
//       ArrayList List = new ArrayList();
//        //overriding add method of array list
//        public override int Add(object value)
//        {
//            if(Added!=null)
//            {
//                Added();
//            }
//            return base.Add(value);
//        }
//    }


//    class Program
//    {
//        public static void Main(string [] args)
//        {
//            MyArrayList list = new MyArrayList();
//            list.Added+=() => Console.WriteLine("Some data added");
//            list.Add(12);
//            list.Add(13);
//            list.Add(14);
//            list.Add(15);
//            list.Add(16);
//            list.Add(17);
//        }
//    }


//}







