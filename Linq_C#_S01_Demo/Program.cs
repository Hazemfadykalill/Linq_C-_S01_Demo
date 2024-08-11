using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Linq_C__S01_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region C# Keywords [var - Dynamic]
            #region Var
            //var x;//invalid
            //var Y = "Date";
            //    Y = 30;//invalid
            ////var Not use in parameter function and not use return type
            ////var At Compilation type
            ////var Not A data Type 
            //// Must be initialize value to detect data type

            #endregion
            #region Dynamic

            //dynamic
            //at run time
            //dynamic data = "haze";
            //data = true;//invalid
            //data = null;
            //dynamic x;//invalid
            //dynamic like var in JavaScript
            //dynamic in run time like object at compile time
            //dynamic can use (parameter ,return type) with function 
            #endregion

            #endregion

            #region Extension Method

            //int x = 567;
            //x.ReverseNumber();
            //Console.WriteLine(x.ReverseNumber());  //765 
            #endregion

            #region Anonymous Type
            //var Emp = new { Id = 1, Name = "Ahmed", Salary = 12000 };
            //Console.WriteLine(Emp);//{ Id = 1, Name = Ahmed, Salary = 12000 }
            //                       //By Default override On ToString Method 
            //var Emp02 = new { Id = 1, Name = "Ahmed", Salary = 12000 };
            //Console.WriteLine(Emp02);//{ Id = 1, Name = Ahmed, Salary = 12000 }
            //Console.WriteLine(Emp.GetType().Name);
            //Console.WriteLine(Emp02.GetType().Name);

            ////Equals
            //if (Emp.Equals(Emp02))
            //{
            //    Console.WriteLine("Equals");
            //}

            #endregion

            #region LinQ

            #region Overview
            // List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,10,12};
            //var Result= list.Where(x => x % 2 == 0);
            // foreach (var x in Result)
            // { 
            //     Console.Write(" " + x);
            // } 
            #endregion
            #region Syntax LINQ
            #region 1. Fluent LINQ
            //use linQ method
            //1.1 use linQ operator throw class Name [Enumerable]
            //List<int> Numbers=new List<int>() { 1,2,3,4,10,5,6,7,8,9};  
            //var Result=Enumerable.Where(Numbers,item =>item%2==0);
            //foreach (var item in Result)
            //{
            //    Console.Write(" " +  item); 

            //}


            //1.2 use linQ operator throw Extension Method [Recommended]
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 10, 5, 6, 7, 8, 9 };
            //var Result =Numbers.Where( item => item % 2 == 0);
            //foreach (var item in Result)
            //{
            //    Console.Write(" " + item);

            //}
            #endregion

            #region 2. Query syntax
            //call too query expression
            //like SQL  style 
            //start always c# keyword from 
            //end  always c# keyword select


            //List<int> Numbers = new List<int>() { 1,2,3,4,5,6,4,5,8,9,7,10,15,17};
            //var Result=from N in Numbers
            //           where N%2==0
            //           select N;
            //foreach (var item in Result)
            //{
            //    Console.Write(" " + item);
            //}

            #endregion
            #endregion


            #endregion
        }
    }
}
