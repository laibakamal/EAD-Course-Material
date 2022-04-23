//11/4/2022

//online lecture # 62,63

using System;
namespace Lecture6
{

    class Student
    {
        public int RollNum { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
    }


    class Lecturee6
    {
        public static void Main(string[] args)
        {
            //QUERY SYNTAX IN LINQ
            //1- define data source
            string[] cities = new string[]
            {
                "LHR","KHI","ISL","Istanbul"
            };

            //2- define query
            //is where k function me aisi function pass krna hai jo string value receive kry ga aur bool return kry ga
            var query = from n in cities where n.Length>5 select n;//important :  QUERY IS DEFINED ONLYYYYYYY, DATA IS NOT RETRIEVED, NEITHER THE QUERY ISN EXECUTED
            //as in SQL, select class is used to select the desired attributes/columns from datasource, same here, in LINQ query syntax, select is used for same purpose


            //3- Query Execution
            //here the query is being executed, where we are actually using it.
            foreach (var city in query)//QUERY EXECUTION
            {
                Console.WriteLine(city);
            }










            //TASK: return only name and roll number of student class using LINQ (any syntax), assume that there are other attributes also in the class.
            Student s1 = new Student { RollNum=1, Name="Laiba" };
            Student s2 = new Student { RollNum=2, Name="Iqra" };
            Student[] s = new Student[] { s1, s2 };

            var query1 = from n in s where n.Name.Length>4 select (s1.Name, s1.RollNum);

            foreach (var n in query1)//QUERY EXECUTION
            {
                Console.WriteLine(n.Name);
            }
        }

        static bool NameLongerThanFour(string cityName)
        {
            return cityName.Length>4;
        }


    }


}


//1) LINQ (practice) --> filter out data out of an array of countries --> solution in lec5 file
//extension methods, they are not the part of that class for which they are being called but are defined in some else namespace
//func --> built-in delegate
//Where method used in LINQ queries: 



//3 steps of LINQ
//1- define data source
//2- define query
//3- Query Execution

//anonymous method : anonymous fnctions and lambda expressions and lambda statements
//delegates

//query syntax of LINQ


//the method by which we can define and execute the query in same place