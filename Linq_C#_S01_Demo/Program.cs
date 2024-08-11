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
        }
    }
}
