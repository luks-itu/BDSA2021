using System;
using System.Collections.Generic;

namespace ExampleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {


            string input;
            int year;
            bool isLeapYear;
            string errormessage;
            errormessage = "Please enter a valid year. Try again. Please enter a year (after 1582) and then press enter:";


            Console.WriteLine("Please enter a year (after 1582) and then press enter:");

            while(true)
            {

            input = Console.ReadLine();


            try
            {
                year = Convert.ToInt32(input);
                if (year <= 1582)
                {
                    Console.WriteLine(errormessage);
                    continue;
                }
                break;
            }
            catch (System.Exception)
            {
                Console.WriteLine(errormessage);
                continue;
            }

            }

            isLeapYear = IsLeapYear(year);

            if(isLeapYear)
            {
                Console.WriteLine("yay");
            } 
            else
            {
                Console.WriteLine("nay");
            }


        }

        public static bool IsLeapYear(int year)
        {

            if (year%4 == 0 & year%100 != 0 |  year%4==0 & year%100 == 0 & year%400==0   ) 
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
