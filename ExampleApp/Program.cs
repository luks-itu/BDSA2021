using System;

namespace ExampleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           // Console.WriteLine(1400%4);
            //isLeapYear(1848); <-- this is how you call it
        }

        public static bool IsLeapYear(int year)
        {
            if (year%4 == 0 & year%100 != 0 |  year%4==0 & year%100 == 0 & year%400==0 ) 
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }
    }
}
