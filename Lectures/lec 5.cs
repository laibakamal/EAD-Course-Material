//lecture 5


//using System;
//using System.Collections;

//namespace Lec5
//{

//    class MyEventArgs : EventArgs
//    {
//        public int Count { get; set; }
//        public object ListData { get; set; }
//    }

//    class Program
//    {
//        //first parameter will be object, second parameter will be a event args or a class inherited from event args class,
//        //jub bhi event se related koi extra info bhenni hogi
//        delegate void EventHandler(object sender, MyEventArgs e);
//        delegate void EventHandlerr(object sender, EventArgs e);

//        //publisher class
//        //is k 2 kaam hoty hein: event ko define krna aur raise krna
//        class MyArrayList : ArrayList
//        {
//            public event EventHandler Added;
//            private int c = 1;
//            public void OnAdded(object value)
//            {
//                MyEventArgs args = new MyEventArgs();
//                args.Count=c++;
//                args.ListData =value; 
//                //raising/firing the event
//                Added(this, args);
//            }
//            public override int Add(object? value)//ye method array list ki class me already defined hai
//            {
//                OnAdded(value);
//                return base.Add(value);
//            }
//        }
//        public static void Main(string[]args)
//        {
//            MyArrayList list = new MyArrayList();
//            list.Added+=delegate (object sender, MyEventArgs e)
//            {
//                Console.WriteLine($"Count: {e.Count}\t\tData: {e.ListData}");
//            };
//            list.Add(12);
//            list.Add("amna");
//            list.Add(0.5M);
//            list.Add('y');

//        }
//    }

//}


//task 1: hum list ka count maintain krna chah ry hein k jitni baar list me koi data
//add ho yaani jitni baaar event fire ho, utni baar count increment ho
//soln: is k liye ek class bnayen gy my event args ki jo event args se inherited hai,
//us me ek public property bnayen gy count ki, aur us count ko tub tub inc kren gy jub 
//jub event fire hoga

//task2: hum chahty hein k list me user jo jo data add kr raha hai, wo bhi hum get kr rhy hon
//soln: is k liye hum event args ki hi class me ek property bnayen gy, object type ki
//property bnayen gy aur her baar jub list me value add hogi tou usy parameter me get kr k set kr den gy



// yahan tak event handling ka topic hum ne khatam kr lia, 
//is k baad windows form pe chalay gye thy

//homework: basic calculator on windows form



//next topic: LINQ
//LINQ: language integrated query
//query krny ki capability language me integrated hai


//data sources can be of different types: xml files, array lists, lists, database , collection classes (arrays, lists, array lists), etc
//the way of retreiving data from each data soucrce is different
//ku na saray data sources se data retrieve krny (query krny ) ka tareeka same kr diya jaye






using System;
using System.Linq;
namespace lec5Linq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] cities = new string[]
            {
                "LHR","KHI","ISL","Istanbul"
            };


            //is where k function me aisi function pass krna hai jo string value receive kry ga aur bool return kry ga
            var query = cities.Where(NameLongerThanFour);

            foreach (var city in query)
            {
                Console.WriteLine(city);
            }
        }

        static bool NameLongerThanFour(string cityName)
        {
            return cityName.Length>4;
        }

    }

}